using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerance.Infrastucture.Commands.User;
using Ecommerance.Infrastucture.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EcommeranceApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ApiControllerBase
    {
        private readonly IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        // mozliwe tylko dla osob uwiezytelnionych
        public async Task<IActionResult> Get()
        => Json(await _userService.GetAccountAsync(UserId));





        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> Post([FromBody]Register command)
        {
            await _userService.RegisterAsync(Guid.NewGuid(), command.Email, command.Name, 
                                            command.Name, command.Password, command.Role);

            return Created("/account", null);
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Post([FromBody]Login command)
            => Json(await _userService.LoginAsync(command.Email, command.Password));

    }
}