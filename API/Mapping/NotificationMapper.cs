using AutoMapper;
using SofraKebab.DTOLayer.NotificationDTO;
using SofraKebab.EntityLayer.Entities;

namespace API.Mapping
{
    public class NotificationMapper : Profile
    {
        public NotificationMapper()
        {
            CreateMap<ResultNotificationDto, Notification>().ReverseMap();
            CreateMap<CreateNotificationDto, Notification>().ReverseMap();
            CreateMap<GetByIdNotificationDto, Notification>().ReverseMap();
            CreateMap<UpdateNotificationDto, Notification>().ReverseMap();
        }
    }
}
