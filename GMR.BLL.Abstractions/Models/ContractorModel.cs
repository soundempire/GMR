using System.Collections.Generic;

namespace GMR.BLL
{
    public class ContractorModel
    {
        public long ID { get; set; }

        public string ContractorID { get; set; }

        public long PersonID { get; set; }

        public string Name { get; set; }
        //TODO: think about collection type
        public ICollection<TransactionModel> Transactions { get; set; }
    }
}
