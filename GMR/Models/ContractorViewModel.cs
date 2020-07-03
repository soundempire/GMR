using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace GMR.Models
{
    internal class ContractorViewModel : ICloneable
    {
        [Browsable(false)]
        public long ID { get; set; }

        [DisplayName("ID")]
        [ReadOnly(true)]
        public string ContractorID { get; set; }

        [Browsable(false)]
        public long PersonID { get; set; }

        [DisplayName("Контрагент")]
        public string Name { get; set; }

        [Browsable(false)]
        public List<TransactionViewModel> Transactions { get; set; }

        object ICloneable.Clone() => MemberwiseClone();

        public override int GetHashCode() => Name.GetHashCode();

        public override bool Equals(object obj)
        {
            if (obj is ContractorViewModel constractorModel)
            {
                if (ReferenceEquals(this, constractorModel))
                    return true;

                return ContractorID == constractorModel.ContractorID && Name == constractorModel.Name;
            }

            return false;
        }
    }
}
