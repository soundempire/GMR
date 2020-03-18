using ExcelDataReader;
using GMR.BLL.Abstractions.Models;
using GMR.BLL.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GMR.BLL.Services
{
    public class ImportService : IImportService
    {
        private readonly IContractorService _contractorService;

        public ImportService(IContractorService contractorService) =>
            _contractorService = contractorService;

        public async Task<IEnumerable<ImportResultRow<ContractorModel>>> ImportContractors(string fileName, long personId)
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

                                var validatedEntries = await CreateContractorEntries(contractorRows, personId);

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

        private async Task<List<ValidatedImportRow<ContractorModel>>> CreateContractorEntries(IEnumerable<DataRow> contractorRows, long personId)
        {
            var validatedEntries = new List<ValidatedImportRow<ContractorModel>>();

            ContractorModel contractor;

            for (int i = 0; i < contractorRows.Count(); i++)
            {
                DataRow dr = contractorRows.ElementAt(i);
                TransactionModel transaction;

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

                var validateContractorError = await ValidateContractor(contractor, personId);

                if (string.IsNullOrEmpty(validateContractorError.ToString()))
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

                //check if contractor already exist
                //var existContractors = _contractorRepository.GetAll()
                //                                            .Include(c => c.Transactions)
                //                                            .ToList();

                //if (existContractors.Find(c => dr[2].ToString().Contains(c.Name)) == null) {}
            }
            return validatedEntries;
        }

        private async Task<string> ValidateContractor(ContractorModel contractor, long personId)
        {           
            if (string.IsNullOrEmpty(contractor.Name))
                return "Имя контрагента не может быть пустым.";

            var contractors = (await _contractorService.GetContractorsAsync(personId)).Select(c=>c);

            if (contractors != null)
                foreach (ContractorModel c in contractors)
                    if (contractor ==c)
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
                if (headerFormat[i].Trim() != headers[i].Trim())
                    return $"Колонка {i + 1} в заголовке должна называться '{headers[i]}'.";

            return error;
        }
    }
}
