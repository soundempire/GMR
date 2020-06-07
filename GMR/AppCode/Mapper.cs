using AutoMapper;
using GMR.BLL.Abstractions.Models;
using GMR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMR
{
    public static class Mapper
    {
        private static readonly IMapper _mapper;

        static Mapper()
        {
            _mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PersonModel, UpdatePersonViewModel>();
                cfg.CreateMap<PasswordModel, UpdatePasswordViewModel>();
                cfg.CreateMap<ContractorModel, ImportContractorViewModel>()
                   .ForMember(x => x.Date, op => op.MapFrom(y => y.Transactions == null || y.Transactions.FirstOrDefault() == null ? default : y.Transactions.First().Date))
                   .ForMember(x => x.Value, op => op.MapFrom(y => y.Transactions == null || y.Transactions.FirstOrDefault() == null ? default : y.Transactions.First().Value))
                   .ForMember(x => x.Price, op => op.MapFrom(y => y.Transactions == null || y.Transactions.FirstOrDefault() == null ? default : y.Transactions.First().Price))
                   .ForMember(x => x.Currency, op => op.MapFrom(y => y.Transactions == null || y.Transactions.FirstOrDefault() == null ? default : y.Transactions.First().Currency));

                cfg.CreateMap<UpdatePersonViewModel, PersonModel>();
                cfg.CreateMap<UpdatePasswordViewModel, PasswordModel>()
                   .ForMember(x => x.Value, op => op.MapFrom(y => y.NewValue))
                   .ForMember(x => x.LastUpdated, op => op.MapFrom(y => DateTime.Now));
                cfg.CreateMap<ImportContractorViewModel, ContractorModel>()
                   .ForMember(x => x.ID, op => op.Ignore())
                   .ForMember(x => x.Transactions, op => op.MapFrom(y => new HashSet<TransactionModel>()
                   {
                       new TransactionModel { Date = y.Date, Value = y.Value, Price = y.Price, Currency = y.Currency}
                   }));
            }).CreateMapper();
        }

        public static M Map<V, M>(V entity) => _mapper.Map<M>(entity);
    }
}
