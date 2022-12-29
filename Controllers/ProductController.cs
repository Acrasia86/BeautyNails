using BeautyNails.Data;
using BeautyNails.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BeautyNails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
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

            return new OkObjectResult(products);
        }

        [HttpGet("{id?}")]
        [AllowAnonymous]
        public async Task<ActionResult> GetProduct(int id)
        {
            var product = await _context.Product.FirstOrDefaultAsync(x => x.Id == id);

            if(product == null)
            {
                return new NotFoundResult();
            }

            return new OkObjectResult(product);
        }

        [HttpPost]
        public async Task<ActionResult> PostProduct(Product product)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if(product == null)
            {
                return BadRequest("Object was null");
            }
            await _context.Product.AddAsync(product);
            await _context.SaveChangesAsync();

            return Ok(product);
        }
    }
}
