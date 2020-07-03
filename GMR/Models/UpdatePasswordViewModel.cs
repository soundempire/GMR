using System;
using System.ComponentModel.DataAnnotations;

namespace GMR.Models
{
    internal class UpdatePasswordViewModel
    {
        public long ID { get; set; }

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

        [Required]
        public DateTime LastUpdated { get; set; }
    }
}
