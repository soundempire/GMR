using GMR.DAL.Abstractions.Entities;
using GMR.DAL.Configurations;
using System.Data.Entity;

namespace GMR.DAL.Context
{
    public class GMRContext : DbContext
    {
        public DbSet<Password> Passwords { get; set; }

        public DbSet<Person> Persons { get; set; }

        public DbSet<Contractor> Contractors { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        public GMRContext()
            : base("name=GMR") { }

#if DEBUG
        static GMRContext() => Database.SetInitializer(new DBInitializer());
#endif

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PersonConfiguration());
            modelBuilder.Configurations.Add(new PasswordConfiguration());
            modelBuilder.Configurations.Add(new TransactionConfiguration());
            modelBuilder.Configurations.Add(new ContractorConfiguration());
        }
    }
}
