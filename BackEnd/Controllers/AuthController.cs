﻿using BackEnd.DTO;
using BackEnd.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<IdentityUser> userManager;
        private ITokenService TokenService;

        public AuthController(UserManager<IdentityUser> _userManager, ITokenService tokenService) {
            userManager = _userManager;
            TokenService = tokenService;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO model) {
            IdentityUser user = await userManager.FindByNameAsync(model.Username);
            LoginDTO Usuario = new LoginDTO();
            if (user != null && await userManager.CheckPasswordAsync(user, model.Password)) {

                var userRoles = await userManager.GetRolesAsync(user);

                var jwtToken = TokenService.GenerateToken(user, userRoles.ToList());

                Usuario.Token = jwtToken;
                Usuario.Roles = userRoles.ToList();
                Usuario.Username = user.UserName;


                return Ok(Usuario);
            }

            return Unauthorized();
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDTO model) {

            var userExists = await userManager.FindByNameAsync(model.Username);

            if (userExists != null) {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            IdentityUser user = new IdentityUser {
                Email = model.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.Username
            };

            var result = await userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded) {
                return StatusCode(StatusCodes.Status500InternalServerError);

            }

            return Ok();

        }
    }
}
