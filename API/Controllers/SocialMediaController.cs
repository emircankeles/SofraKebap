using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SofraKebab.BusinessLayer.Abstract;
using SofraKebab.DTOLayer.SocialMediaDTO;
using SofraKebab.EntityLayer.Entities;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        private readonly ISocialmediaService _socialmediaservice;
        private readonly IMapper _mapper;

        public SocialMediaController(IMapper mapper, ISocialmediaService socialmediaService)
        {
            _socialmediaservice = socialmediaService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult SocialmediaList()
        {
            var value = _mapper.Map<List<ResultSocialmediaDto>>(_socialmediaservice.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateSocialmedia(CreateSocialmediaDto createSocialmediaDto)
        {
            _socialmediaservice.TAdd(new SocialMedia()
            {
                Icon = createSocialmediaDto.Icon,
                Title = createSocialmediaDto.Title,
                Url = createSocialmediaDto.Url
            });
            return Ok("Sosyal medya bilgisi eklendi.");
        }
        [HttpDelete]
        public IActionResult DeleteSocialmedia(int id)
        {
            var value = _socialmediaservice.TGetByID(id);
            _socialmediaservice.TDelete(value);
            return Ok("Silindi.");
        }
        [HttpGet("GetSocialmedia")]
        public IActionResult GetSocialmedia(int id)
        {
            var value = _socialmediaservice.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateSocialmedia(UpdateSocialmediaDto updateSocialmediaDto)
        {
            _socialmediaservice.TUpdate(new SocialMedia()
            {
                SocialMediaID = updateSocialmediaDto.SocialMediaID,
                Title = updateSocialmediaDto.Title,
                Url = updateSocialmediaDto.Url,
                Icon = updateSocialmediaDto.Icon
            });
            return Ok("Güncellendi.");
        }
    }
}
