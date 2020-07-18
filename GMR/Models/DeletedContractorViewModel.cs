using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMR.Models
{
    public class DeletedContractorViewModel
    {
        [Browsable(false)]
        public long ID { get; set; }

        [DisplayName("ID")]
        public string ContractorID { get; set; }

        [DisplayName("Контрагент")]
        public string Name { get; set; }

        [Browsable(false)]
        public long PersonID { get; set; }

        [Browsable(false)]
        public bool Deleted { get; set; }
    }
}
