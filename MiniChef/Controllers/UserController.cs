using Microsoft.AspNetCore.Mvc;
using MiniChef.Domain.IService;
using MiniChef.Domain.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MiniChef.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpPost("CadastrarUsuario")]
        public async Task<IActionResult> CadastrarUsuario(User user)
        {
            if (user == null)
            {
                return BadRequest();
            }

            var createdUser = await _service.CreateUserService(user);
            return CreatedAtAction(nameof(CadastrarUsuario), new { id = createdUser.id }, createdUser);
        }
    }
}
