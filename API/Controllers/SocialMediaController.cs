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
        private readonly ISocialmediaService _socialMediaservice;
        private readonly IMapper _mapper;

        public SocialMediaController(IMapper mapper, ISocialmediaService socialmediaService)
        {
            _socialMediaservice = socialmediaService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult SocialmediaList()
        {
            var value = _mapper.Map<List<ResultSocialmediaDto>>(_socialMediaservice.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateSocialmedia(CreateSocialmediaDto createSocialmediaDto)
        {
            var value = _mapper.Map<SocialMedia>(createSocialmediaDto);
            _socialMediaservice.TAdd(value);
            return Ok("Sosyal medya bilgisi eklendi.");
        }
        [HttpDelete]
        public IActionResult DeleteSocialmedia(int id)
        {
            var value = _socialMediaservice.TGetByID(id);
            _socialMediaservice.TDelete(value);
            return Ok("Silindi.");
        }
        [HttpGet("GetSocialmedia")]
        public IActionResult GetSocialmedia(int id)
        {
            var value = _socialMediaservice.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateSocialmedia(UpdateSocialmediaDto updateSocialmediaDto)
        {
            var value = _mapper.Map<SocialMedia>(updateSocialmediaDto);
            _socialMediaservice.TUpdate(value);
            return Ok("Güncellendi.");
        }
    }
}
