using AutoMapper;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SofraKebab.BusinessLayer.Abstract;
using SofraKebab.DataAccessLayer.Concreate;
using SofraKebab.DTOLayer.ProductDTO;
using SofraKebab.EntityLayer.Entities;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IMapper mapper, IProductService productService)
        {
            _productService = productService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult ProductList()
        {
            var value = _mapper.Map<List<ResultProductDto>>(_productService.TGetListAll());
            return Ok(value);
        }
        [HttpGet("ProductCount")]
        public IActionResult ProductCount()
        {
            return Ok(_productService.TProductCount());
        }

        [HttpGet("ProductCountByDrink")]
        public IActionResult ProductCountByDrink()
        {
            return Ok(_productService.TProductCountByCategoryNameDrink());
        }

        [HttpGet("ProductCountByDöner")]
        public IActionResult ProductCountByDöner()
        {
            return Ok(_productService.TProductCountByCategoryNameDöner());
        }
        [HttpGet("AvgDönerPrice")]
        public IActionResult AvgDönerPrice()
        {
            return Ok(_productService.TAvgDönerPrice());
        }
        [HttpGet("ProductPriceAVG")]
        public IActionResult ProductPriceAVG()
        {
            return Ok(_productService.TProductPriceAVG());
        }
        [HttpGet("MaxProductPrice")]
        public IActionResult MaxProductPrice()
        {
            return Ok(_productService.TMaxProductPrice());
        }
        [HttpGet("MinProductPrice")]
        public IActionResult MinProductPrice()
        {
            return Ok(_productService.TMinProductPrice());
        }
        [HttpGet("ProductListwithCategory")]
        public IActionResult ProductListwithCategory() 
        {
            var context = new SofraKebabContext();
            var values=context.Products.Include(x => x.Category).Select(y => new ResultProductwithCategory
            {
                Description = y.Description,
                ImageUrl = y.ImageUrl,
                Price = y.Price,
                ProductName = y.ProductName,
                ProductId = y.ProductId,
                ProductStatus = y.ProductStatus,
                Name=y.Category.Name
            });
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateProduct(CreateProductDto createProductDto)
        {
            _productService.TAdd(new Product()
            {
                Description = createProductDto.Description,
                ImageUrl = createProductDto.ImageUrl,
                Price = createProductDto.Price,
                ProductName = createProductDto.ProductName,
                ProductStatus = createProductDto.ProductStatus
            });
            return Ok("Ürün bilgisi eklendi.");
        }
        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.TGetByID(id);
            _productService.TDelete(value);
            return Ok("Silindi.");
        }
        [HttpGet("GetProduct")]
        public IActionResult GetProduct(int id)
        {
            var value = _productService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            _productService.TUpdate(new Product()
            {
                ProductId = updateProductDto.ProductId,
                Description = updateProductDto.Description,
                ImageUrl = updateProductDto.ImageUrl,
                Price = updateProductDto.Price,
                ProductName = updateProductDto.ProductName,
                ProductStatus = updateProductDto.ProductStatus
            });
            return Ok("Güncellendi.");
        }
    }
}
