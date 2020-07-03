using System.Data.Entity.ModelConfiguration;

namespace GMR.DAL.Configurations
{
    internal class PasswordConfiguration : EntityTypeConfiguration<Password>
    {
        public PasswordConfiguration()
        {
            ToTable("Passwords");
            HasKey(_ => _.ID);
            HasRequired(_ => _.Person).WithRequiredPrincipal(_ => _.Password);
            Property(_ => _.Login).IsRequired();
            Property(_ => _.Value).IsRequired();
            Property(_ => _.LastUpdated).IsRequired();
        }
    }
}
