﻿using System;

namespace GMR.BLL
{
    public class PasswordModel
    {
        public long ID { get; set; }

        public long PersonID { get; set; }

        public string Login { get; set; }

        public string Value { get; set; }

        public DateTime? LastUpdated { get; set; }
    }
}
