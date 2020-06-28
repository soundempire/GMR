using System;

namespace GMR.BLL
{
    public class TransactionModel
    {
        public long ID { get; set; }

        public long ContractorID { get; set; }

        public DateTime Date { get; set; }

        public double? Value { get; set; }

        public double? Price { get; set; }

        public double Currency { get; set; }
    }
}
