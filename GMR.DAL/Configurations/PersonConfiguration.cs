using System.Data.Entity.ModelConfiguration;

namespace GMR.DAL.Configurations
{
    internal class PersonConfiguration : EntityTypeConfiguration<Person>
    {
        public PersonConfiguration()
        {
            HasKey(p => p.ID);
            Property(p => p.FirstName).IsRequired().HasMaxLength(50);
            Property(p => p.LastName).IsRequired().HasMaxLength(50);
            Property(p => p.Language).IsRequired().HasMaxLength(10).HasColumnType("varchar");
            Property(p => p.Phone).IsRequired().HasMaxLength(12).IsFixedLength().HasColumnType("varchar");
        }
    }
}
