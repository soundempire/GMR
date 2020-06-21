using System;
using System.ComponentModel.DataAnnotations;

namespace GMR.Models
{
    internal class CreatePasswordViewModel
    {
        [Required]
        public string Login { get; set; }

        [Required]
        public string Value { get; set; }

        [Required]
        [Compare(nameof(Value))]
        public string ConfirmValue { get; set; }

        [Required]
        public DateTime? LastUpdated { get; set; }
    }
}
