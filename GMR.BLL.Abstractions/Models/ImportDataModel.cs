using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMR.BLL.Abstractions.Models
{
    public class ImportDataModel
    {
        [DisplayName("№ п/п")]
        public long ID { get; set; }

        [DisplayName("Контрагент")]
        public string Name { get; set; }

        [DisplayName("ID")]
        public string ContractorID { get; set; }

        [DisplayName("Дата")]
        public DateTime? Date { get; set; }

        [DisplayName("Транзакция")]
        public double? Value { get; set; } = null;

        [DisplayName("Платеж")]
        public double? Price { get; set; }

        [DisplayName("Курс")]
        public double Currency { get; set; }
    }
}
