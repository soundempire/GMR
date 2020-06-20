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
                cfg.CreateMap<Password, PasswordModel>().ReverseMap();
                cfg.CreateMap<Transaction, TransactionModel>().ReverseMap();
                cfg.CreateMap<Contractor, ContractorModel>().ReverseMap();
                cfg.CreateMap<ContractorModel, PotentialContractorModel>().ReverseMap();

                cfg.CreateMap<PersonModel, Person>()
                    .ForMember(x => x.Language, op => op.MapFrom(y => y.Language.Id));
            }).CreateMapper();
        }

        public static M Map<V, M>(V entity) => _mapper.Map<M>(entity);
    }
}
