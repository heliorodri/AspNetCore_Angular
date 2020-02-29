using System.Threading.Tasks;
using DattingApp.API.Data;
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
        public async Task<IActionResult> Register(string username, string password)
        {
            //Validate request
            username = username.ToLower();

            if (await this._repo.UserExists(username))
                return BadRequest("Usuário já existe");
            
            var userToCreate = new User{Username = username};
            var createdUser = await this._repo.Register(userToCreate, password);

            //change to CreatedAtRoute when the method is ready
            return StatusCode(201);
        }
    }
}