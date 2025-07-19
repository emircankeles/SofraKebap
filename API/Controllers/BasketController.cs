using API.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SofraKebab.BusinessLayer.Abstract;
using SofraKebab.DataAccessLayer.Concreate;
using SofraKebab.DTOLayer.BasketDTO;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private readonly IBasketService _basketService;
        private readonly IMapper _mapper;

        public BasketController(IMapper mapper,IBasketService basketService)
        {
            _mapper = mapper;
            _basketService = basketService;
        }
        [HttpGet]
        public IActionResult GetBasketByMenuTableId(int id)
        {
            var values = _basketService.TGetBasketByMenuTableNumber(id);
            return Ok(values);
        }
        [HttpGet("BasketListByMenuTableWithProductName")]
        public IActionResult BasketListByMenuTableWithProductName(int id)
        {
            using var context = new SofraKebabContext();
            var values = context.Baskets.Include(r => r.Product).Where(b => b.MenuTableID == id).Select(e => new ResultBasketListWithProducts
            {
                BasketID = e.BasketID,
                Count = e.Count,
                MenuTableID = e.MenuTableID,
                Price = e.Price,
                ProductID = e.ProductID,
                TotalPrice = e.TotalPrice,
                ProductName = e.Product.ProductName
            }).ToList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateBasket(CreateBasketDto createBasketDto)
        {
            using var context = new SofraKebabContext();
            _basketService.TAdd(new SofraKebab.EntityLayer.Entities.Basket()
            {
                ProductID = createBasketDto.ProductID,
                MenuTableID = createBasketDto.MenuTableID,
                Count = 1,
                Price = context.Products.Where(r => r.ProductId == createBasketDto.ProductID).Select(b => b.Price).FirstOrDefault(),
                TotalPrice = createBasketDto.TotalPrice
            });
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBasket(int id)
        {
            var value = _basketService.TGetByID(id);
            _basketService.TDelete(value);
            return Ok("Sepetteki Seçilen Ürün Silindi");
        }
    }
}
