
using AutoMapper;
using Demo.Listings.Domain.Models;

namespace Demo.Listings.Api.Mappers
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Dtos.CreateListingReq, Listing>();
            CreateMap<Listing, Dtos.ListingResp>();
        }
    }
}

