using System.ComponentModel.DataAnnotations;

namespace GMR.Models
{
    internal class UpdatePersonViewModel
    {
        public long ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        public UpdatePasswordViewModel Password { get; set; }

        public string Country { get; set; }

        public string Company { get; set; }

        [Required]
        public LanguageViewModel Language { get; set; }

        [Required]
        [RegularExpression(@"^[0-9\+\-()]+$")]
        [MaxLength(18)]
        public string Phone { get; set; }
    }
}
