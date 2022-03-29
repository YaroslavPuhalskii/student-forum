using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentForum.Api.Models.Authorization;
using StudentForum.BL.Abstractions;
using StudentForum.BL.Models.Authorization;
using System.Linq;
using System.Threading.Tasks;

namespace StudentForum.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : BaseController
    {
        private readonly IUserService _userService;

        private readonly ITokenService _tokenService;

        public AccountController(IMapper mapper, IUserService userService, ITokenService tokenService) 
            : base(mapper)
        {
            _userService = userService;
            _tokenService = tokenService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest)
        {
            var request = Mapper.Map<AuthInfo>(loginRequest);

            var user = await _userService.Authenticate(request);

            var jwt = _tokenService.Generete(user);

            return Ok(jwt);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest registerRequest)
        {
            var request = Mapper.Map<RegisterInfo>(registerRequest);

            await _userService.Create(request);

            return Ok("success");
        }

        [Authorize]
        [HttpGet("user")]
        public async Task<IActionResult> GetUser()
        {
            var jwt = HttpContext.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            var token = _tokenService.Verify(jwt);

            var userId = token.Claims.FirstOrDefault(x => x.Type.Equals("sub")).Value;

            var user = await _userService.GetById(int.Parse(userId));

            return Ok(user);
        }
    }
}
