using System.Collections.Generic;

namespace GMR.DAL
{
    public class Person
    {
        public long ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Password Password { get; set; }

        public string Country { get; set; }

        public string Company { get; set; }

        public string Phone { get; set; }

        public string Language { get; set; }

        public ICollection<Contractor> Transactions { get; set; }

        public Person() => Transactions = new HashSet<Contractor>();
    }
}
