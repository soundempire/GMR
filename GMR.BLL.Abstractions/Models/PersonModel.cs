using System;

namespace GMR.BLL
{
    public class PersonModel : ICloneable
    {
        public long ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName => $"{LastName} {FirstName}";

        public PasswordModel Password { get; set; }

        public string Country { get; set; }

        public string Company { get; set; }

        public string Phone { get; set; }

        public LanguageModel Language { get; set; }

        public object Clone()
        {
            var clone = (PersonModel)MemberwiseClone();
            clone.Password = (PasswordModel)clone.Password.Clone();
            clone.Language = (LanguageModel)clone.Language.Clone();

            return clone;
        }
    }
}
