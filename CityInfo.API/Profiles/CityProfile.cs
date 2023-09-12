using AutoMapper;

namespace CityInfo.API.Profiles
{
    public class CityProfile:Profile
    {
        public CityProfile()
        {
            CreateMap<Entities.City, Models.CityWithOutPointOfInterestDto>();
            CreateMap<Entities.City, Models.CityDto>();
        }
    }
}
