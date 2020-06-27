using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMR.BLL.Services
{
    public class ImportService : IImportService
    {
        public async Task<IEnumerable<ContractorModel>> ImportContractors(string fileName)
        {
            return await Task.Run(() => 
            {
                var contractors = new List<ContractorModel>();

                using (FileStream fStream = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    using (var excelReader = ExcelReaderFactory.CreateReader(fStream))
                    {
                        var result = excelReader.AsDataSet(new ExcelDataSetConfiguration()
                        {
                            ConfigureDataTable = _ => new ExcelDataTableConfiguration() { UseHeaderRow = true },
                            UseColumnDataType = true
                        });

                        if (excelReader.FieldCount > 0)
                        {
                            if (excelReader.AsDataSet().Tables?.Count > 0)
                            {
                                var table = result.Tables[0];
                                if (IsContractorFormat(table.Columns, out var _))
                                {
                                    contractors = CreateImportedContractors(table.AsEnumerable());
                                }
                            }
                        }
                        return contractors;
                    }
                }
            }); 
        }
       
        private List<ContractorModel> CreateImportedContractors(IEnumerable<DataRow> importDataRows)
        {
            var importedContractors = new List<ContractorModel>(importDataRows.Count());

            foreach (var row in importDataRows)
            {
                ContractorModel contractor = new ContractorModel()
                {
                    ID = Convert.ToInt64(row[0].ToString().Trim()),
                    ContractorID = row[1].ToString().Trim(),
                    Name = row[2].ToString().Trim(),
                    Transactions = new List<TransactionModel>
                    {
                        new TransactionModel
                        {
                            Date = row[3].ToString().Trim() == string.Empty ? default : Convert.ToDateTime(row[3].ToString()),
                            Value = row[4].ToString().Trim() == string.Empty ? default(double?) : double.Parse(row[4].ToString().Trim()),
                            Price = row[5].ToString().Trim() == string.Empty ? default(double?) : double.Parse(row[5].ToString().Trim()),
                            Currency = double.Parse(row[6].ToString().Trim())
                        }
                    }
                };

                importedContractors.Add(contractor);
            }

            return importedContractors;
        }
       
        private bool IsContractorFormat(DataColumnCollection columns, out string error)
        {
            error = string.Empty;
            var headers = new List<string>() { "№ п/п", "Id", "Контрагент" , "Дата" , "Транзакция", "Платеж", "Курс"};

            if (columns.Count != 7)
            {
                error = "В импортируемом файле должно быть 7 колонок.";
                return false;
            }

            var errorBuilder = new StringBuilder();
            for (int i = 0; i < columns.Count; i++)
            {
                if (columns[i].ToString().Trim() != headers[i].Trim())
                {
                    errorBuilder.AppendLine($"Колонка {(i + 1).ToString()} в заголовке должна называться '{headers[i]}'."); 
                }
            }

            if (errorBuilder.Length > 0)
            {
                error = errorBuilder.ToString();
                return false;
            }

            return true;
        }
    }
}
