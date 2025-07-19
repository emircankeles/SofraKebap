using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SofraKebab.BusinessLayer.Abstract;
using SofraKebab.DTOLayer.MessageDTO;
using SofraKebab.EntityLayer.Entities;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService _messageService;
        private readonly IMapper _mapper;

        public MessageController(IMapper mapper, IMessageService messageService)
        {
            _mapper = mapper;
            _messageService = messageService;
        }
        [HttpGet]
        public IActionResult MessageList()
        {
            var values = _messageService.TGetListAll();
            return Ok(_mapper.Map<List<ResultMessageDto>>(values));
        }
        [HttpPost]
        public IActionResult CreateMessage(CreateMessageDto createMessageDto)
        {
            createMessageDto.Status = false;
            createMessageDto.MessageSendDate = DateTime.Now;
            var value = _mapper.Map<Message>(createMessageDto);
            _messageService.TAdd(value);
            return Ok("Mesaj başarıyla gönderildi.");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteMessage(int id)
        {
            var value = _messageService.TGetByID(id);
            _messageService.TDelete(value);
            return Ok("Mesaj silindi.");
        }
        [HttpPut]
        public IActionResult UpdateMessage(UpdateMessageDto updateMessageDto)
        {
            var value = _mapper.Map<Message>(updateMessageDto);
            _messageService.TUpdate(value);
            return Ok("Mesaj bilgisi güncellendi.");
        }
        [HttpGet("{id}")]
        public IActionResult GetMessage(int id)
        {
            var value = _messageService.TGetByID(id);
            return Ok(_mapper.Map<GetByIdMessageDto>(value));
        }
    }
}
