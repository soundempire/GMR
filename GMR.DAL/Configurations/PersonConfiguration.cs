using System.Data.Entity.ModelConfiguration;

namespace GMR.DAL.Configurations
{
    internal class PersonConfiguration : EntityTypeConfiguration<Person>
    {
        public PersonConfiguration()
        {
            ToTable("People");
            HasKey(_ => _.ID);
            Property(_ => _.FirstName).IsRequired()
                                      .HasMaxLength(50);
            Property(_ => _.LastName).IsRequired()
                                     .HasMaxLength(50);
            Property(_ => _.Country).IsOptional();
            Property(_ => _.Company).IsOptional();
            Property(_ => _.Language).IsRequired()
                                     .HasMaxLength(10)
                                     .HasColumnType("varchar");
            Property(_ => _.Phone).IsRequired()
                                  .HasMaxLength(18)
                                  .HasColumnType("varchar");
            HasMany(_ => _.Contractors).WithRequired(_ => _.Person)
                                       .HasForeignKey(_ => _.PersonID)
                                       .WillCascadeOnDelete();
        }
    }
}
