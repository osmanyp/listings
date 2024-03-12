using AutoMapper;
using Demo.Listings.Domain.Models;

namespace Demo.Listings.Infrastructure.Mappers
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Listing, DataAccess.EF.Entities.Listing>()
                    .ReverseMap();
        }
    }
}

