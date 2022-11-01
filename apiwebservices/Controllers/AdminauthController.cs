using apiwebservices.DTO.admin;
using apiwebservices.Extensions;
using apiwebservices.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace apiwebservices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminauthController : ControllerBase
    {
        private readonly SignInManager<Admindto> _signInManager;
        private readonly UserManager<Admindto> _userManager;
        private readonly TokenHelper _tokenService;
       

        public AdminauthController(SignInManager<Admindto> signInManager, UserManager<Admindto> userManager, TokenHelper tokenService)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _tokenService = tokenService;
        }

        [Authorize]
        [HttpGet]
        public async Task<ActionResult<Admindto>> GetCurrentUser()
        {
            return null;
        }
           
    }
}
