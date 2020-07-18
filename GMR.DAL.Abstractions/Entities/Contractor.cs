using System.Collections.Generic;

namespace GMR.DAL
{
    public class Contractor
    {
        public long ID { get; set; }

        public string ContractorID { get; set; }

        public long PersonID { get; set; }

        public Person Person { get; set; }

        public string Name { get; set; }

        public bool Deleted { get; set; }

        public ICollection<Transaction> Transactions { get; set; }

        public Contractor() => Transactions = new HashSet<Transaction>();
    }
}
