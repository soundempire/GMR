using GMR.DAL.Abstractions.Entities;
using System.Data.Entity.ModelConfiguration;

namespace GMR.DAL.Configurations
{
    internal class PasswordConfiguration : EntityTypeConfiguration<Password>
    {
        public PasswordConfiguration()
        {
            HasOptional(pass => pass.Person).WithRequired(pers => pers.Password);
            HasKey(pasword => pasword.ID);
        }
    }
}
