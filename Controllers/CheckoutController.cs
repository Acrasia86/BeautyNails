using AutoMapper;
using BeautyNails.Data;
using BeautyNails.DTOs;
using BeautyNails.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BeautyNails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckoutController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;

        public CheckoutController(ApplicationDbContext context, UserManager<AppUser> userManager, IMapper mapper)
        {
            _context = context;
            _userManager = userManager;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> GetCheckOut(Guid id)
        {
            var checkout = await _context.CheckOut.FirstOrDefaultAsync(x => x.Id == id);

            var checkoutMap = _mapper.Map<CheckoutDto>(checkout);

            if (checkoutMap == null)
            {
                return NotFound("Checkout was null");
            }

            return new OkObjectResult(checkoutMap);
        }

     
        [HttpPost]
        public async Task<ActionResult> PostCheckOut(CheckoutDto checkoutDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (checkoutDto == null)
            {
                return BadRequest("Object was null");
            }
            
            var checkout = _mapper.Map<Checkout>(checkoutDto);
            checkout.User = _userManager.FindByEmailAsync(User.Identity.Name).Result;

            await _context.CheckOut.AddAsync(checkout);
            await _context.SaveChangesAsync();

            return Ok(checkout);
        }
        [HttpGet("CheckoutService")]
        public async Task<ActionResult> CheckoutProduct()
        {
            var checkoutProduct = await _context.CheckOut.Include(x => x.Product).ToListAsync();
            
            return Ok(checkoutProduct);
        }

        [HttpGet("GetAllCheckouts")]
        public async Task<ActionResult> GetAllCheckouts()
        {
            var checkouts = await _context.CheckOut.ToListAsync();
            if(checkouts == null)
            {
                return NotFound();
            }
            return Ok(checkouts);
        }
    }
}
