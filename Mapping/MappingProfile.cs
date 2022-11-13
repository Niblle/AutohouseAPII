using AutoMapper;
using Data.Entities;
using ViewModels;

namespace Mapping
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
           CreateMap<ModelViewModel, Model>();



            CreateMap<ManufacturerViewModel, Manufacturer>();
              
                
        }
    }
}