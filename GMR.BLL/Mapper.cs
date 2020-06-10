using AutoMapper;
using GMR.DAL;

namespace GMR.BLL
{
    public static class Mapper
    {
        private static readonly IMapper _mapper;

        static Mapper()
        {
            _mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Person, PersonModel>()
                    .ForMember(x => x.Language, op => op.MapFrom(y => new LanguageModel() { Id = y.Language }));
                cfg.CreateMap<Password, PasswordModel>();
                cfg.CreateMap<Transaction, TransactionModel>();
                cfg.CreateMap<Contractor, ContractorModel>();
                cfg.CreateMap<ContractorModel, PotentialContractorModel>();

                cfg.CreateMap<PasswordModel, Password>();
                cfg.CreateMap<TransactionModel, Transaction>();
                cfg.CreateMap<ContractorModel, Contractor>();
                cfg.CreateMap<PersonModel, Person>()
                    .ForMember(x => x.Language, op => op.MapFrom(y => y.Language.Id));
                cfg.CreateMap<PotentialContractorModel, ContractorModel>();
            }).CreateMapper();
        }

        public static M Map<V, M>(V entity) => _mapper.Map<M>(entity);
    }
}
