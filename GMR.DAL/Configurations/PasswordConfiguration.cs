using System.Data.Entity.ModelConfiguration;

namespace GMR.DAL.Configurations
{
    internal class PasswordConfiguration : EntityTypeConfiguration<Password>
    {
        public PasswordConfiguration()
        {
            HasRequired(pass => pass.Person).WithRequiredPrincipal(pers => pers.Password);
            HasKey(pasword => pasword.ID);
            Property(p => p.Login).IsRequired();
            Property(p => p.Value).IsRequired();
            Property(p => p.LastUpdated).IsRequired();
        }
    }
}
