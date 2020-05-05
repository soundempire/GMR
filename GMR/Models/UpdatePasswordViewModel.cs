using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMR.Models
{
    internal class UpdatePasswordViewModel
    {
        public long ID { get; set; }

        public string PersonID { get; set; }

        public UpdatePersonViewModel Person { get; set; }

        [Required]
        public string Login { get; set; }

        [Required]
        public string Value { get; set; }

        [Required]
        [Compare(nameof(Value))]
        public string OldValue { get; set; }

        [Required]
        public string NewValue { get; set; }

        [Required]
        [Compare(nameof(NewValue))]
        public string ConfirmValue { get; set; }

        public DateTime? LastUpdated { get; set; }
    }
}
