using AutoMapper;
using BeautyNails.Data;
using BeautyNails.DTOs;
using BeautyNails.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BeautyNails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public HomeController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult> GetAbout()
        {
            var about = await _context.About.ToListAsync();

            if (about == null)
            {
                return new NotFoundResult();
            }

            return Ok(about.Select(ab => _mapper.Map<AboutDto>(ab)));
        }

        [HttpPost]
        public async Task<ActionResult> PostAbout(AboutDto aboutDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (aboutDto == null)
            {
                return BadRequest("Object was null");
            }

            var about = _mapper.Map<About>(aboutDto);
            
            await _context.About.AddAsync(about);
            await _context.SaveChangesAsync();

            return Ok(about);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAbout(int id)
        {
            var about = _context.About.FirstOrDefault(x => x.Id == id);
            if (about == null)
            {
                return NotFound("About not found");
            }
            if (id < 0)
            {
                return BadRequest("Id can't be less then 0");
            }
            _context.About.Remove(about);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateAbout(int id, AboutDto aboutDto)
        {

            if (aboutDto == null)
            {
                return BadRequest("Product was null");
            }

            if (id != aboutDto.Id)
            {
                return BadRequest("Id not found");
            }

            if (id < 0)
            {
                return BadRequest("Id can't be less then 0");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var about = _mapper.Map<About>(aboutDto);

            try
            {
                _context.About.Update(about);

                await _context.SaveChangesAsync();


                return NoContent();


            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }


        }
    }
}
