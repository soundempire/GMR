using Autofac;
using GMR.BLL;
using GMR.BLL.Services;
using GMR.DAL;
using GMR.DAL.Context;
using GMR.DAL.Repositories;

namespace GMR
{
    internal static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<GMRContext>();

            builder.RegisterType<LoginForm>();
            builder.RegisterType<MainForm>();
            builder.RegisterType<AddContractorForm>();
            builder.RegisterType<UserAccountForm>();
            builder.RegisterType<ImportMasterForm>();

            builder.RegisterType<PasswordRepository>().As<IRepository<Password>>();
            builder.RegisterType<ContractorRepository>().As<ISpecifyRepository<Contractor>>();
            builder.RegisterType<PersonRepository>().As<IRepository<Person>>();
            builder.RegisterType<TransactionRepository>().As<IRepository<Transaction>>();

            builder.RegisterType<AuthorizationService>().As<IAuthorizationService>();
            builder.RegisterType<PersonService>().As<IPersonService>();
            builder.RegisterType<ContractorService>().As<IContractorService>();
            builder.RegisterType<TransactionService>().As<ITransactionService>();
            builder.RegisterType<ImportService>().As<IImportService>();
            builder.RegisterType<PotentialContractorsService>().As<IPotentialContractorsService>();
            builder.RegisterType<LanguagesService>().As<ILanguagesService>();

            return builder.Build();
        }
    }
}
