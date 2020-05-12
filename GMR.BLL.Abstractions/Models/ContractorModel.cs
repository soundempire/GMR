using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace GMR.BLL.Abstractions.Models
{
    public class ContractorModel : ICloneable
    {
        [Browsable(false)]
        public long ID { get; set; }

        [DisplayName("ID")]
        [ReadOnly(true)]
        public string ContractorID { get; set; }

        [Browsable(false)]
        public long PersonID { get; set; }

        [Browsable(false)]
        public PersonModel Person { get; set; }

        [DisplayName("Контрагент")]
        public string Name { get; set; }

        [Browsable(false)]
        public ICollection<TransactionModel> Transactions { get; set; }

        public object Clone() => MemberwiseClone();

        public override int GetHashCode() => Name.GetHashCode();

        public override bool Equals(object obj)
        {
            if (obj is ContractorModel constractorModel)
            {
                if (ReferenceEquals(this, constractorModel))
                    return true;

                return ContractorID == constractorModel.ContractorID && Name == constractorModel.Name;
            }

            return false;
        }
    }
}
