using Autofac;
using GMR.BLL;
using GMR.BLL.Services;
using GMR.DAL;
using GMR.DAL.Context;
using GMR.DAL.Repositories;
using GMR.Infrastructure;

namespace GMR
{
    internal static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            
            builder.RegisterType<Logger>().As<ILogger>().SingleInstance();
            builder.RegisterType<Сryptographer>().As<IСryptographer>().SingleInstance();

            builder.RegisterType<GMRContext>();

            builder.RegisterType<LoginForm>();
            builder.RegisterType<MainForm>();
            builder.RegisterType<AddTransactionForm>();
            builder.RegisterType<UpdateUserAccountForm>();
            builder.RegisterType<CreateUserAccountForm>();
            builder.RegisterType<ImportMasterForm>();
            builder.RegisterType<ResetPasswordForm>();

            builder.RegisterType<PasswordRepository>().As<IPasswordRepository>();
            builder.RegisterType<ContractorRepository>().As<IContractorRepository>();
            builder.RegisterType<PersonRepository>().As<IPersonRepository>();
            builder.RegisterType<TransactionRepository>().As<ITransactionRepository>();

            builder.RegisterType<AuthorizationService>().As<IAuthorizationService>();
            builder.RegisterType<PersonService>().As<IPersonService>();
            builder.RegisterType<ContractorService>().As<IContractorService>();
            builder.RegisterType<TransactionService>().As<ITransactionService>();
            builder.RegisterType<ExcelManager>().As<IExcelManager>();
            builder.RegisterType<PotentialContractorsService>().As<IPotentialContractorsService>();
            builder.RegisterType<PotentialLoginService>().As<IPotentialLoginService>();
            builder.RegisterType<LanguagesService>().As<ILanguagesService>();

            return builder.Build();
        }
    }
}
