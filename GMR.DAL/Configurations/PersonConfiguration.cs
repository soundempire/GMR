using GMR.DAL.Abstractions.Entities;
using System.Data.Entity.ModelConfiguration;

namespace GMR.DAL.Configurations
{
    internal class PersonConfiguration : EntityTypeConfiguration<Person>
    {
        public PersonConfiguration()
        {        
            Property(p => p.FirstName).IsRequired().HasMaxLength(50);
            Property(p => p.LastName).IsRequired().HasMaxLength(50);
            Property(p => p.Phone).IsRequired().HasMaxLength(12).IsFixedLength().HasColumnType("varchar");
        }
    }
}
