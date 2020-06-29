using AutoMapper;
using GMR.BLL;
using GMR.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GMR
{
    public static class Mapper
    {
        private static readonly IMapper _mapper;

        static Mapper()
        {
            _mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TransactionModel, TransactionViewModel>().ReverseMap();
                cfg.CreateMap<ContractorModel, ContractorViewModel>().ReverseMap();
                cfg.CreateMap<LanguageModel, LanguageViewModel>().ReverseMap();
                cfg.CreateMap<PersonModel, UpdatePersonViewModel>().ReverseMap();
                cfg.CreateMap<PotentialContractorModel, ContractorViewModel>();
                cfg.CreateMap<CreatePersonViewModel, PersonModel>();
                cfg.CreateMap<CreatePasswordViewModel, PasswordModel>();
                cfg.CreateMap<PasswordModel, UpdatePasswordViewModel>();
                cfg.CreateMap<ContractorModel, ImportContractorViewModel>()
                   .ForMember(x => x.Date, op => op.MapFrom(y => y.Transactions == null || y.Transactions.FirstOrDefault() == null ? default : y.Transactions.First().Date))
                   .ForMember(x => x.Value, op => op.MapFrom(y => y.Transactions == null || y.Transactions.FirstOrDefault() == null ? default : y.Transactions.First().Value))
                   .ForMember(x => x.Price, op => op.MapFrom(y => y.Transactions == null || y.Transactions.FirstOrDefault() == null ? default : y.Transactions.First().Price))
                   .ForMember(x => x.Currency, op => op.MapFrom(y => y.Transactions == null || y.Transactions.FirstOrDefault() == null ? default : y.Transactions.First().Currency));

                cfg.CreateMap<UpdatePasswordViewModel, PasswordModel>()
                   .ForMember(x => x.Value, op => op.MapFrom(y => y.NewValue));
                cfg.CreateMap<ImportContractorViewModel, ContractorModel>()
                   .ForMember(x => x.ID, op => op.Ignore())
                   .ForMember(x => x.Transactions, op => op.MapFrom(y => new List<TransactionModel>()
                   {
                       new TransactionModel { Date = y.Date, Value = y.Value, Price = y.Price, Currency = y.Currency }
                   }));
            }).CreateMapper();
        }

        public static M Map<V, M>(V entity) => _mapper.Map<M>(entity);
    }
}
