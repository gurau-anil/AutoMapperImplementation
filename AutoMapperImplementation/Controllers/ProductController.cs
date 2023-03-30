using AutoMapper;
using AutoMapperImplementation.DTOs;
using AutoMapperImplementation.Entities;
using AutoMapperImplementation.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperImplementation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IProductService _productservice;
        public ProductController(IProductService productservice, IMapper mapper)
        {
            _productservice = productservice;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _productservice.GetAll();
            var mappedProducts = _mapper.Map<IEnumerable<ProductDTO>>(products);
            return Ok(products);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _productservice.Get(id);
            return Ok(product);
        }
    }
}
