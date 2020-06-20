using System;

namespace GMR.BLL
{
    public class PasswordModel
    {
        public long ID { get; set; }

        public string PersonID { get; set; }

        public PersonModel Person { get; set; }

        public string Login { get; set; }

        public string Value { get; set; }

        public DateTime? LastUpdated { get; set; }
    }
}
