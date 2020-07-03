using System;

namespace GMR.DAL
{
    public class Password
    {
        public long ID { get; set; }

        public Person Person { get; set; }

        public string Login { get; set; }

        public string Value { get; set; }

        public DateTime LastUpdated { get; set; }
    }
}
