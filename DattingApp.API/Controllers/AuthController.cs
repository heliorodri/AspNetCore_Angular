using System.Threading.Tasks;
using DattingApp.API.Data;
using DattingApp.API.Dtos;
using DattingApp.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DattingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repo;
        
        public AuthController(IAuthRepository repo){this._repo = repo;}

        [HttpPost("Register")]
        public async Task<IActionResult> Register(UserForRegisterDto userForRegisterDto)
        {
            //Validate request
            userForRegisterDto.Username = userForRegisterDto.Username.ToLower();

            if (await this._repo.UserExists(userForRegisterDto.Username))
                return BadRequest("Usuário já existe");
            
            var userToCreate = new User{Username = userForRegisterDto.Username};
            var createdUser = await this._repo.Register(userToCreate, userForRegisterDto.Password);

            //change to CreatedAtRoute when the method is ready
            return StatusCode(201);
        }
    }
}