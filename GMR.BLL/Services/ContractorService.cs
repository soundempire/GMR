using ExcelDataReader;
using GMR.BLL.Abstractions.Models;
using GMR.BLL.Abstractions.Services;
using GMR.DAL.Abstractions;
using GMR.DAL.Abstractions.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GMR.BLL.Services
{
    public class ContractorService : IContractorService, IDisposable
    {
        private readonly ISpecifyRepository<Contractor> _contractorRepository;

        public ContractorService(ISpecifyRepository<Contractor> contractorRepository)
            => _contractorRepository = contractorRepository;

        public async Task<ContractorModel> GetContractorAsync(long id)
        {
            var dataModel = await _contractorRepository.GetAsync(id);
            return Mapper.Map<Contractor, ContractorModel>(dataModel);
        }

        public async Task<IEnumerable<ContractorModel>> GetContractorsAsync(long personId, string filter = null)
        {
            var query = _contractorRepository.GetAllFor(personId);
            if (!string.IsNullOrWhiteSpace(filter))
            {
                query = query.Where(c => c.Name.ToLower().Contains(filter.ToLower()));
            }
            var dataModel = await query.ToListAsync();

            return Mapper.Map<IEnumerable<Contractor>, IEnumerable<ContractorModel>>(dataModel);
        }

        public async Task<ContractorModel> UpdateContractorAsync(ContractorModel contractor)
        {
            var ctr = Mapper.Map<ContractorModel, Contractor>(contractor);

            await _contractorRepository.UpdateAsync(ctr);

            return Mapper.Map<Contractor, ContractorModel>(ctr);
        }

        public void Dispose() => _contractorRepository.Dispose();

        public List<ImportResultRow<ContractorModel>> ImportContractors(string fileName)
        {
            try
            {
                var resultList = new List<ImportResultRow<ContractorModel>>();

                using (FileStream fStream = File.Open(fileName, FileMode.Open, FileAccess.Read))
                {
                    using (var excelReader = ExcelReaderFactory.CreateReader(fStream))
                    {
                        var result = excelReader.AsDataSet(new ExcelDataSetConfiguration() { ConfigureDataTable = _ => new ExcelDataTableConfiguration() { UseHeaderRow = true }, UseColumnDataType = true });

                        int colCount = excelReader.FieldCount;

                        if (colCount > 0)
                        {
                            if (excelReader.AsDataSet().Tables != null && excelReader.AsDataSet().Tables.Count > 0)
                            {
                                var dt = result.Tables[0];

                                List<string> columnNames = new List<string>();

                                foreach (var item in dt.Columns)
                                    columnNames.Add(item.ToString());

                                var error = IsContractorFormat(columnNames);

                                if (string.IsNullOrEmpty(error))
                                {
                                    IEnumerable<DataRow> contractorRows = dt.AsEnumerable().Select(row => row);

                                    var validatedEntries = CreateContractorEntries(contractorRows);

                                    //var importResult = SaveImportedVendors(validatedEntries.Where(x => x.IsValid).Select(x => x.Item).ToList());

                                    foreach (var validatedRow in validatedEntries)
                                    {
                                        var resultItem = new ImportResultRow<ContractorModel> { Item = validatedRow.Item, Error = validatedRow.Error };
                                        //if (validatedRow.IsValid)
                                        //{
                                        //    resultItem.Error = importResult.Single(x => x.Item == validatedRow.Item).Error;
                                        //}

                                        resultList.Add(resultItem);
                                    }
                                }
                            }
                        }
                        return resultList;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private List<ValidatedImportRow<ContractorModel>> CreateContractorEntries(IEnumerable<DataRow> contractorRows)
        {
            var validatedEntries = new List<ValidatedImportRow<ContractorModel>>();

            ContractorModel contractor;

            for (int i = 0; i < contractorRows.Count(); i++)
            {
                DataRow dr = contractorRows.ElementAt(i);
                TransactionModel transaction;

                try
                {
                    contractor = new ContractorModel()
                    {
                        ID = Convert.ToInt64(dr[0].ToString().Trim()),
                        ContractorID = dr[1].ToString().Trim(),
                        Name = dr[2].ToString().Trim()
                    };

                    transaction = new TransactionModel()
                    {
                        ContractorID = contractor.ID,
                        Date = Convert.ToDateTime(dr[3].ToString()),
                        Value = (string.IsNullOrEmpty(dr[4].ToString().Trim()) ? (double?)null : double.Parse(dr[4].ToString().Trim())),
                        Price = (string.IsNullOrEmpty(dr[5].ToString().Trim()) ? (double?)null : double.Parse(dr[5].ToString().Trim())),
                        Currency = double.Parse(dr[6].ToString().Trim()),
                        Contractor = contractor
                    };

                    contractor.Transactions = new List<TransactionModel>();

                    if (contractor.Name.Length > 50)
                    {
                        validatedEntries.Add(ValidatedImportRow<ContractorModel>.CreateWithError("Импортируемые данные не в корректном формате. Длина имени контрагента не может превышать 50 символов."));
                        continue;
                    }

                    if (transaction.Value != null && transaction.Value < 0)
                    {
                        validatedEntries.Add(ValidatedImportRow<ContractorModel>.CreateWithError("Импортируемые данные не в корректном формате. Значение транзакции не может быть отрицательным."));
                        continue;
                    }

                    if (transaction.Price != null && transaction.Value < 0)
                    {
                        validatedEntries.Add(ValidatedImportRow<ContractorModel>.CreateWithError("Импортируемые данные не в корректном формате. Значение платежа не может быть отрицательным."));
                        continue;
                    }

                    if (transaction.Currency < 0)
                    {
                        validatedEntries.Add(ValidatedImportRow<ContractorModel>.CreateWithError("Импортируемые данные не в корректном формате. Курс не может быть отрицательным."));
                        continue;
                    }

                    var validateContractorError = ValidateContractor(contractor);

                    if (string.IsNullOrEmpty(validateContractorError))
                    {
                        if (validatedEntries.Count(x => x.IsValid && x.Item.Name == contractor.Name && x.Item.Transactions.Contains(transaction)) >= 1)
                            validatedEntries.Add(new ValidatedImportRow<ContractorModel> { Error = "Контрагент с такой транзакцией уже присутствует в файле импорта." });
                        else
                        {
                            contractor.Transactions.Add(transaction);
                            validatedEntries.Add(new ValidatedImportRow<ContractorModel> { Item = contractor });
                        }
                    }
                    else
                    {
                        validatedEntries.Add(new ValidatedImportRow<ContractorModel> { Error = $"Импортируемые данные не в корректном формате. {validateContractorError}" });
                        continue;
                    }
                }
                catch (Exception)
                {
                    throw;
                }

                //check if contractor already exist
                //var existContractors = _contractorRepository.GetAll()
                //                                            .Include(c => c.Transactions)
                //                                            .ToList();

                //if (existContractors.Find(c => dr[2].ToString().Contains(c.Name)) == null) {}
            }
            return validatedEntries;
        }

        private string ValidateContractor(ContractorModel contractor)
        {
            if (string.IsNullOrEmpty(contractor.Name))
                return "Имя контрагента не может быть пустым.";
            else if (GetContractorAsync(contractor.ID) != null)
                return "Контрагент уже существует.";

            return string.Empty;
        }

        private string IsContractorFormat(List<string> headerFormat)
        {
            string error = string.Empty;
            List<string> headers = new List<string>()
            { "№ п/п", "Id", "Контрагент" , "Дата" ,
            "Транзакция", "Платеж", "Курс"};

            if (headerFormat.Count > 7)
                return $"В импортируемом файле должно быть 7 колонок.";

            for (int i = 0; i < headerFormat.Count; i++)
            {
                if (headerFormat[i].Trim() != headers[i].Trim())
                    return $"Колонка {i + 1} в заголовке должна называться '{headers[i]}'.";
                break;
            }

            return error;
        }
    }
}
