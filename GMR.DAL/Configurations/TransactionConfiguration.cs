using System.Data.Entity.ModelConfiguration;

namespace GMR.DAL.Configurations
{
    internal class TransactionConfiguration : EntityTypeConfiguration<Transaction>
    {
        public TransactionConfiguration()
        {
            ToTable("Transactions");
            HasKey(_ => _.ID);
            Property(_ => _.Date).IsRequired();
            Property(_ => _.Currency).IsRequired();
            Property(_ => _.Value).IsOptional();
            Property(_ => _.Price).IsOptional();
        }
    }
}
