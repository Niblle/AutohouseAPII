using AutoMapper;
using Data.Entities;
using System.Diagnostics.Metrics;
using ViewModels;

namespace Mapper
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<Model, ModelViewModel>()
                  .ForMember(dest => dest.Vehicle_type, act => act.MapFrom(src => src.VehicleType))
                  .ForMember(dest => dest.Manufacturer, act => act.MapFrom(src => src.Name));

            CreateMap<Manufacturer, ManufacturerViewModel>()
                .ForMember(dest => dest.Manufacturer, act => act.MapFrom(src => src.Name));

            CreateMap<CarSpecification, CarSpecificationViewModel>()
               .ForMember(dest => dest.Engine_size, act => act.MapFrom(src => src.EngineSize));
               


        }
    }
}