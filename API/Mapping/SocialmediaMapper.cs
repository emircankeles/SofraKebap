using AutoMapper;
using SofraKebab.DTOLayer.SocialMediaDTO;
using SofraKebab.EntityLayer.Entities;

namespace API.Mapping
{
    public class SocialmediaMapper : Profile
    {
        public SocialmediaMapper()
        {
            CreateMap<SocialMedia, ResultSocialmediaDto>().ReverseMap();
            CreateMap<SocialMedia, CreateSocialmediaDto>().ReverseMap();
            CreateMap<SocialMedia, UpdateSocialmediaDto>().ReverseMap();
            CreateMap<SocialMedia, GetSocialMediaDto>().ReverseMap();
        }
    }
}
