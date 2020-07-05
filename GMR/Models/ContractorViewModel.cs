using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GMR.Models
{
    internal class ContractorViewModel : ICloneable
    {
        [Browsable(false)]
        public long ID { get; set; }

        [DisplayName("ID")]
        [ReadOnly(true)]
        [Required]
        public string ContractorID { get; set; }

        [Browsable(false)]
        [Required]
        public long PersonID { get; set; }

        [DisplayName("Контрагент")]
        [Required]
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
