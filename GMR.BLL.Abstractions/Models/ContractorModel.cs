using System.Collections.Generic;

namespace GMR.BLL
{
    public class ContractorModel
    {
        public long ID { get; set; }

        public string ContractorID { get; set; }

        public long PersonID { get; set; }

        public string Name { get; set; }

        public List<TransactionModel> Transactions { get; set; }

        public override int GetHashCode() => (ContractorID, Name).GetHashCode();

        public override bool Equals(object obj)
        {
            if (obj is ContractorModel contractor)
            {
                if (ReferenceEquals(this, contractor))
                    return true;

                return ContractorID == contractor.ContractorID &&
                       Name == contractor.Name;
            }

            return false;
        }
    }
}
