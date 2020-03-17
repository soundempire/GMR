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

                cfg.CreateMap<UpdatePersonViewModel, PersonModel>();
                cfg.CreateMap<UpdatePasswordViewModel, PasswordModel>()
                .ForMember(x => x.Value, op => op.MapFrom(y => y.NewValue))
                .ForMember(x => x.LastUpdated, op => op.MapFrom(y => DateTime.Now));
            }).CreateMapper();
        }

        public static M Map<V, M>(V entity) => _mapper.Map<M>(entity);
    }
}
