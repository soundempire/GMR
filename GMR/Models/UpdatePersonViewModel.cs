﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMR.Models
{
    class UpdatePersonViewModel
    {
        public long ID { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public UpdatePasswordViewModel Password { get; set; }

        public string Country { get; set; }

        public string Company { get; set; }

        [Required]
        public string Phone { get; set; }
    }
}