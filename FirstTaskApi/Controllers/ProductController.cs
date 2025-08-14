using AutoMapper;
using BusinessLayer.Abstract;
using DtoLayer.Dtos.ProductDtos;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstTaskApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetProductList()
        {
            var values =_productService.GetList();
            return Ok(_mapper.Map<List<ResultProductDto>>(values));
        }
        [HttpPost]
        public IActionResult CreateProduct(CreateProductDto createProductDto)
        {
            var value = _mapper.Map<Product>(createProductDto);
            _productService.Add(value);
            return Ok("product added successfully");
        }
        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            var value = _mapper.Map<Product>(updateProductDto);
            _productService.Update(value);
            return Ok("product updated successfully");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.GetById(id);
            _productService.Delete(value);
            return Ok("product deleted successfully");
        }
        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var value = _productService.GetById(id);
            return Ok(_mapper.Map<GetProductDto>(value));
        }
    }
}
