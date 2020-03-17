using AutoMapper;
using GMR.BLL.Abstractions.Models;
using GMR.DAL.Abstractions.Entities;

namespace GMR.BLL
{
    public static class Mapper
    {
        private static readonly IMapper _mapper;

        static Mapper()
        {
            _mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Person, PersonModel>();
                cfg.CreateMap<Password, PasswordModel>();
                cfg.CreateMap<Transaction, TransactionModel>();
                cfg.CreateMap<Contractor, ContractorModel>();

                cfg.CreateMap<PasswordModel, Password>();
                cfg.CreateMap<TransactionModel, Transaction>();
                cfg.CreateMap<ContractorModel, Contractor>();
                cfg.CreateMap<PersonModel, Person>();
            }).CreateMapper();
        }

        public static M Map<V, M>(V entity) => _mapper.Map<M>(entity);
    }
}
