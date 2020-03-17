using System;

namespace GMR.DAL.Abstractions.Entities
{
    public class Transaction
    {
        public long ID { get; set; }

        public long ContractorID { get; set; }

        public Contractor Contractor { get; set; }

        public DateTime? Date { get; set; }

        public double? Value { get; set; } = null;

        public double? Price { get; set; } = null;

        public double Currency { get; set; }
    }
}
