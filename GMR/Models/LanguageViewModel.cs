using System.ComponentModel.DataAnnotations;

namespace GMR.Models
{
    internal class LanguageViewModel
    {
        [Required]
        [MaxLength(10)]
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
