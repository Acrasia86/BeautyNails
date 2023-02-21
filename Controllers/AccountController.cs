using BeautyNails.Data;
using BeautyNails.DTOs;
using BeautyNails.Models;
using BeautyNails.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace BeautyNails.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly TokenService _tokenService;
        private readonly ApplicationDbContext _context;

        public AccountController(UserManager<AppUser> userManager, TokenService tokenService, ApplicationDbContext context)
        {
            _userManager = userManager;
            _tokenService = tokenService;
            _context = context;
        }

        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> Login(LoginDto loginDto)
        {
            var user = await _userManager.FindByEmailAsync(loginDto.Email);
            if (user == null) 
            {
                return Unauthorized();
            } 
            
            var result = await _userManager.CheckPasswordAsync(user, loginDto.Password);

            if(result)
            {
                return CreateUserObject(user);
            }

            return Unauthorized();
        }

    
        [HttpPost("register")]
        public async Task<ActionResult<UserDto>> Register(RegisterDto registerDto)
        {
            if(await _userManager.Users.AnyAsync(x => x.UserName == registerDto.UserName))
            {
                return BadRequest("Username already exists");
            }
            var user = new AppUser
            {
                DisplayName = registerDto.DisplayName,
                Email = registerDto.Email,
                UserName = registerDto.UserName,
                BirthDay = registerDto.BirthDay
            };

            if(user == null)
            {
                return NotFound();
            }

            var result = await _userManager.CreateAsync(user, registerDto.Password);

            if(result.Succeeded)
            {
                return CreateUserObject(user);
            }
            return BadRequest("Problem registering user");
        }

        
        [HttpGet]
        public async Task<ActionResult<UserDto>> GetCurrentUser()
        {
            var user = await _userManager.FindByEmailAsync(User.FindFirstValue(ClaimTypes.Email));

            if(user == null)
            {
                return NotFound();
            }

            return CreateUserObject(user);
        }


        [HttpGet("getrole")]
        public async Task<ActionResult> GetRole()
        {

            var userEmail = this.User.FindFirstValue(ClaimTypes.Email);
            var user = await _userManager.FindByEmailAsync(userEmail);
            var role = await _userManager.GetRolesAsync(user);

            return Ok(role);

        }

    [HttpGet("GetAllUsers")]
        public async Task<ActionResult> GetAllUsers()
        {
            var users = await _userManager.Users.ToListAsync();
            if(users == null)
            {
                return NotFound();
            }
            return Ok(users);
        }

        [HttpGet("Birthday")]
        public async Task<ActionResult> BirthDay()
        {
            var birthDay = await _context.Users.Where(x => x.BirthDay== DateTime.Today).ToListAsync();
            return Ok(birthDay);
        }

        private UserDto CreateUserObject(AppUser user)
        {

            return new UserDto
            {
                DisplayName = user.DisplayName,
                Image = null,
                Token = _tokenService.CreateToken(user),
                UserName = user.UserName
            };
        }

    }
}
