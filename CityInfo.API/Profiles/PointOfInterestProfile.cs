using AutoMapper;
using CityInfo.API.Models;

namespace CityInfo.API.Profiles
{
    public class PointOfInterestProfile:Profile
    {
        public PointOfInterestProfile()
        {
            CreateMap<Entities.PointOfInterest, PointOfInterestDto>().ReverseMap();
            CreateMap<Entities.PointOfInterest, PointOfInterestForCreationDto>().ReverseMap();
            CreateMap<Entities.PointOfInterest, Models.PointOfInterestForUpdateDto>();
            CreateMap<Models.PointOfInterestForUpdateDto,Entities.PointOfInterest>();
        }
    }
}
