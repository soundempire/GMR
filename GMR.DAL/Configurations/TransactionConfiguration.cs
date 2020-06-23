using System.Data.Entity.ModelConfiguration;

namespace GMR.DAL.Configurations
{
    internal class TransactionConfiguration : EntityTypeConfiguration<Transaction>
    {
        public TransactionConfiguration()
        {
            HasKey(t => t.ID);
            Property(t => t.Date).IsRequired();
            Property(t => t.Currency).IsRequired();
        }
    }
}
