﻿using Autofac;
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

            builder.RegisterType<LoadingForm>();
            builder.RegisterType<LoginForm>();
            builder.RegisterType<MainForm>();
            builder.RegisterType<AddTransactionForm>();
            builder.RegisterType<UpdateUserAccountForm>();
            builder.RegisterType<CreateUserAccountForm>();
            builder.RegisterType<ImportMasterForm>();
            builder.RegisterType<ResetPasswordForm>();
            builder.RegisterType<RecycleBinForm>(); 

            builder.RegisterType<PasswordRepository>().As<IPasswordRepository>();
            builder.RegisterType<ContractorRepository>().As<IContractorRepository>();
            builder.RegisterType<PersonRepository>().As<IPersonRepository>();
            builder.RegisterType<TransactionRepository>().As<ITransactionRepository>(); 
            builder.RegisterType<HealthCheckRepository>().As<IHealthCheckRepository>();

            builder.RegisterType<AuthorizationService>().As<IAuthorizationService>();
            builder.RegisterType<PersonService>().As<IPersonService>();
            builder.RegisterType<ContractorService>().As<IContractorService>();
            builder.RegisterType<TransactionService>().As<ITransactionService>();
            builder.RegisterType<TransferContractorsService>().As<ITransferContractorsService>();
            builder.RegisterType<PotentialContractorsService>().As<IPotentialContractorsService>();
            builder.RegisterType<PotentialLoginService>().As<IPotentialLoginService>();
            builder.RegisterType<LanguagesService>().As<ILanguagesService>();
            builder.RegisterType<RecycleBinService>().As<IRecycleBinService>(); 
            builder.RegisterType<HealthCheckService>().As<IHealthCheckService>();

            return builder.Build();
        }
    }
}
