using AutoMapper;
using SofraKebab.DTOLayer.SliderDTO;
using SofraKebab.EntityLayer.Entities;

namespace API.Mapping
{
    public class SliderMapper : Profile
    {
        public SliderMapper() 
        {
            CreateMap<Slider, ResultSliderDto>().ReverseMap();
        }
    }
}
