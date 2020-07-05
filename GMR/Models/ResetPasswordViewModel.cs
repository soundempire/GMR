using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMR.Models
{
    internal class ResetPasswordViewModel
    {
        [Required]
        public long ID { get; set; }

        [Required]
        public string Login { get; set; }

        [Required]
        public string Value { get; set; }

        [Required]
        [Compare(nameof(Value))]
        public string ConfirmValue { get; set; }

        [Required]
        public DateTime LastUpdated { get; set; }
    }
}
