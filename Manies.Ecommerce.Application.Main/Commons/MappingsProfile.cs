using AutoMapper;
using Manies.Ecommerce.Application.DTO;
using Manies.Ecommerce.Domain.Entity;

namespace Manies.Ecommerce.Application.Main.Commons
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            CreateMap<Customer, CustomerDto>().ReverseMap();
        }
    }
}
