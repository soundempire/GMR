using Autofac;
using GMR.BLL.Abstractions.Services;
using GMR.BLL.Services;
using GMR.DAL.Abstractions;
using GMR.DAL.Abstractions.Entities;
using GMR.DAL.Context;
using GMR.DAL.Repositories;

namespace GMR.LayoutRoot
{
    internal static class DIContainer
    {
        public static ILifetimeScope Scope { get; set; }

        public static T Resolve<T>() => Scope.Resolve<T>();
    }

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

            builder.RegisterType<PasswordRepository>().As<IRepository<Password>>();
            builder.RegisterType<ContractorRepository>().As<ISpecifyRepository<Contractor>>();
            builder.RegisterType<PersonRepository>().As<IRepository<Person>>();
            builder.RegisterType<TransactionRepository>().As<IRepository<Transaction>>();

            builder.RegisterType<AuthorizationService>().As<IAuthorizationService>();
            builder.RegisterType<PersonService>().As<IPersonService>();
            builder.RegisterType<ContractorService>().As<IContractorService>();
            builder.RegisterType<TransactionService>().As<ITransactionService>();
            builder.RegisterType<ImportService>().As<IImportService>();


            return builder.Build();
        }
    }
}

