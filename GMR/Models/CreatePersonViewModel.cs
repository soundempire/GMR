using System.ComponentModel.DataAnnotations;

namespace GMR.Models
{
    internal class CreatePersonViewModel
    {
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        public CreatePasswordViewModel Password { get; set; }

        public string Country { get; set; }

        public string Company { get; set; }

        [Required]
        public LanguageViewModel Language { get; set; }

        [Required]
        [MaxLength(12)]
        public string Phone { get; set; }
    }
}
