using System.Data.Entity.ModelConfiguration;

namespace GMR.DAL.Configurations
{
    internal class ContractorConfiguration : EntityTypeConfiguration<Contractor>
    {
        public ContractorConfiguration()
        {
            ToTable("Contractors");
            HasKey(_ => _.ID);
            Property(_ => _.ContractorID).IsRequired();
            Property(_ => _.Name).IsRequired()
                                 .HasMaxLength(50);
            Property(_ => _.Deleted).IsRequired();
            HasMany(_ => _.Transactions).WithRequired(_ => _.Contractor)
                                        .HasForeignKey(_ => _.ContractorID)
                                        .WillCascadeOnDelete();
        }
    }
}
