using AutoMapper;
using BlogN.Data.Repositories.IRepository;
using BlogN.Data.Services.IService;
using BlogN.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogN.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UsersController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Authenticate(UserDto userDto)
        {
            var user = _userService.Authenticate(userDto.UserName, userDto.Password);

            if (user == null)
            {
                return BadRequest(new { message = "Username or password is incorrect"});
            }

            return Ok(user);    
        }

        [HttpPost("register")]
        public IActionResult Register(UserDto userDto)
        {
            bool userBool = _userService.IsUniqueUser(userDto.UserName);

            if (!userBool)
            {
                return BadRequest(new { message = "Username already registered" });
            }

            var user = _userService.Register(userDto.UserName, userDto.Password);

            if (user == null)
            {
                return BadRequest(new { message = "An error occurred during registration" });
            }

            return Ok();
        }
    }
}
