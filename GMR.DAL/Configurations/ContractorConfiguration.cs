using GMR.DAL.Abstractions.Entities;
using System.Data.Entity.ModelConfiguration;

namespace GMR.DAL.Configurations
{
    internal class ContractorConfiguration : EntityTypeConfiguration<Contractor>
    {
        public ContractorConfiguration()
        {
            HasKey(c => c.ID);
            Property(c => c.Name).IsRequired().HasMaxLength(50);
        }
    }
}
