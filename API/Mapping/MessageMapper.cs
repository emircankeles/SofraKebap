using AutoMapper;
using SofraKebab.DTOLayer.MessageDTO;
using SofraKebab.EntityLayer.Entities;

namespace API.Mapping
{
    public class MessageMapper:Profile
    {
        public MessageMapper()
        {
            CreateMap<CreateMessageDto, Message>().ReverseMap();
            CreateMap<ResultMessageDto, Message>().ReverseMap();
            CreateMap<GetByIdMessageDto, Message>().ReverseMap();
            CreateMap<UpdateMessageDto, Message>().ReverseMap();
        }
    }
}
