using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMR.Models
{
    internal class UpdatePersonViewModel
    {
        public long ID { get; set; }

        [Required]
        [MaxLength(50)]
        //[MaxLength(5)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        //[MaxLength(5)]
        public string LastName { get; set; }

        [Required]
        public UpdatePasswordViewModel Password { get; set; }

        public string Country { get; set; }

        public string Company { get; set; }

        [Required]
        public LanguageViewModel Language { get; set; }

        [Required]
        [MaxLength(12)]
        //[MaxLength(5)]
        public string Phone { get; set; }
    }
}
