using AutoMapper;
using SofraKebab.DTOLayer.MenuTableDTO;
using SofraKebab.EntityLayer.Entities;

namespace API.Mapping
{
    public class MenuTableMapper : Profile
    {
        public MenuTableMapper()
        {
            CreateMap<MenuTable, ResultMenuTableDto>();
            CreateMap<MenuTable, CreateMenuTableDto>();
            CreateMap<MenuTable, UpdateMenuTableDto>();
            CreateMap<MenuTable, GetMenuTableDto>();
        }
    }
}
