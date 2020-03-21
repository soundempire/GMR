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
        public async Task<IEnumerable<ImportDataModel>> ImportContractors(string fileName)
        {
            var resultList = new List<ImportDataModel>();

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

                            var columnNames = new List<string>();

                            foreach (var item in dt.Columns)
                                columnNames.Add(item.ToString());

                            var error = IsContractorFormat(columnNames);

                            if (string.IsNullOrEmpty(error))
                            {
                                IEnumerable<DataRow> importDataRows = dt.AsEnumerable().Select(row => row);

                                resultList = await Task.Run(() => CreateImportDataEntries(importDataRows));
                            }
                        }
                    }
                    return resultList;
                }
            }
        }
       
        private List<ImportDataModel> CreateImportDataEntries(IEnumerable<DataRow> importDataRows)
        {
            var importDataEntries = new List<ImportDataModel>();

            ImportDataModel importDataEntry;

            for (int i = 0; i < importDataRows.ToList().Count; i++)
            {
                DataRow dr = importDataRows.ElementAt(i);

                importDataEntry = new ImportDataModel()
                {
                    ID = Convert.ToInt64(dr[0].ToString().Trim()),
                    ContractorID = dr[1].ToString().Trim(),
                    Name = dr[2].ToString().Trim(),
                    Date = Convert.ToDateTime(dr[3].ToString()),
                    Value = (string.IsNullOrEmpty(dr[4].ToString().Trim()) ? (double?)null : double.Parse(dr[4].ToString().Trim())),
                    Price = (string.IsNullOrEmpty(dr[5].ToString().Trim()) ? (double?)null : double.Parse(dr[5].ToString().Trim())),
                    Currency = double.Parse(dr[6].ToString().Trim())
                };

                importDataEntries.Add(importDataEntry);
            }
            return importDataEntries;
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
