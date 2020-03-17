namespace GMR.DAL.Abstractions.Entities
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
    }
}
