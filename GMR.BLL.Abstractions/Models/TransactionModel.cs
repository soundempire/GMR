using System;
using System.ComponentModel;

namespace GMR.BLL.Abstractions.Models
{
    public class TransactionModel : ICloneable
    {
        [Browsable(false)]
        public long ID { get; set; }

        [Browsable(false)]
        public long ContractorID { get; set; }

        [Browsable(false)]
        public ContractorModel Contractor { get; set; }

        [DisplayName("Дата")]
        public DateTime? Date { get; set; }

        [DisplayName("Транзакция")]
        public double? Value { get; set; } = null;

        [DisplayName("Платеж")]
        public double? Price { get; set; }

        [DisplayName("Курс")]
        public double Currency { get; set; }

        public object Clone() => MemberwiseClone();

        public override int GetHashCode() => (Date, Value, Price, Currency).GetHashCode();

        public override bool Equals(object obj)
        {
            if (obj is TransactionModel transactionModel)
            {
                if (ReferenceEquals(this, transactionModel))
                    return true;

                return Date == transactionModel.Date &&
                       Value == transactionModel.Value &&
                       Price == transactionModel.Price &&
                       Currency == transactionModel.Currency;
            }

            return false;
        }
    }
}
