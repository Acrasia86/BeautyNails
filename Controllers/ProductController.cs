using AutoMapper;
using BeautyNails.Data;
using BeautyNails.DTOs;
using BeautyNails.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;

namespace BeautyNails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ProductController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult> GetAllProducts()
        {
            var products = await _context.Product.ToListAsync();

            if(products == null)
            {
                return new NotFoundResult();
            }

            return Ok(products.Select(product => _mapper.Map<ProductDto>(product)));
        }

        [HttpGet("{id?}")]
        [AllowAnonymous]
        public async Task<ActionResult> GetProduct(Guid id)
        {
            var product = await _context.Product.FirstOrDefaultAsync(x => x.Id == id);

            var productMap = _mapper.Map<ProductDto>(product);

            if(productMap == null)
            {
                return NotFound("Product not found");
            }

           

            return new OkObjectResult(productMap);
        }

        
        [HttpPost]
       
        public async Task<ActionResult> PostProduct(ProductDto productDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if(productDto == null)
            {
                return BadRequest("Object was null");
            }
            var product = _mapper.Map<Product>(productDto);
            await _context.Product.AddAsync(product);
            await _context.SaveChangesAsync();

            return Ok(product);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProduct(Guid id)
        {
            var product = _context.Product.FirstOrDefault(x => x.Id == id);
            if(product == null)
            {
                return NotFound("Product not found");
            }
            
            _context.Product.Remove(product);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPut("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult> UpdateProduct(ProductDto product)
        {

            if(product == null)
            {
                return BadRequest("Product was null");
            }

            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var productDto = _mapper.Map<Product>(product);
            
            try
            {
             _context.Product.Update(productDto);

             await _context.SaveChangesAsync();

               
             return NoContent();
             
               
            }
            catch(Exception e)
            {
               
                return StatusCode(500, e.Message);
            }

           
        }
    }
}
