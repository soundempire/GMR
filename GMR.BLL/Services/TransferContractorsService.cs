using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMR.BLL.Services
{
    public class TransferContractorsService : ITransferContractorsService
    {
        private readonly string[] _headers = new string[] { "№ п/п", "Id", "Контрагент", "Дата", "Транзакция", "Платеж", "Курс" };
        
        public async Task<IEnumerable<ContractorModel>> ImportContractors(string fileName)
        {
            return await Task.Run(() =>
            {
                using (FileStream fStream = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    using (var workSheet = new Workbook(fileName).Worksheets[0])
                    {
                        var table = workSheet.Cells.ExportDataTableAsString(0, 0, workSheet.Cells.MaxRow + 1, 7, true);

                        if (IsContractorFormat(table.Columns, out var _))
                            return CreateImportedContractors(table.AsEnumerable());

                        return Enumerable.Empty<ContractorModel>();
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
                            Currency = row[6].ToString().Trim() == string.Empty ? default : double.Parse(row[6].ToString().Trim())
                        }
                    }
                };

                importedContractors.Add(contractor);
            }

            return importedContractors;
        }

        public async Task ExportContractors(IEnumerable<ContractorModel> contractors, string fileName)
        {
            await Task.Run(() =>
            {
                var workBook = new Workbook();
                var workSheet = workBook.Worksheets[0];
                var counter = 0;

                workSheet.Cells.ImportArray(_headers, counter, 0, false);

                foreach (var contractor in contractors)
                {
                    foreach (var transaction in contractor.Transactions)
                    {
                        var rowToAdd = new string[] {
                            (++counter).ToString(),
                            contractor.ContractorID.ToString(),
                            contractor.Name,
                            transaction.Date.ToShortDateString(),
                            transaction.Value?.ToString() ?? string.Empty,
                            transaction.Price?.ToString() ?? string.Empty,
                            transaction.Currency.ToString()
                        };
                        workSheet.Cells.ImportArray(rowToAdd, counter, 0, false);
                    }
                }

                workSheet.AutoFitColumns();
                workBook.Save(fileName);
            });
        }


        private bool IsContractorFormat(DataColumnCollection columns, out string error)
        {
            error = string.Empty;

            if (columns.Count != 7)
            {
                error = "В импортируемом файле должно быть 7 колонок.";
                return false;
            }

            var errorBuilder = new StringBuilder();
            for (int i = 0; i < columns.Count; i++)
            {
                if (columns[i].ToString().Trim() != _headers[i].Trim())
                {
                    errorBuilder.AppendLine($"Колонка {(i + 1).ToString()} в заголовке должна называться '{_headers[i]}'.");
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
