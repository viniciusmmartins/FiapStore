using Microsoft.AspNetCore.Mvc;

namespace FiapStore.Controllers
{
    
    [ApiController]
    [Route("Usuario")]
    
    public class UsuarioController : ControllerBase
    {
        [HttpGet ("ObterTodosUsuarios")]
        public IActionResult ObterUsuarios()
        {
            return Ok("Usuário retornado com sucesso!");
        }

        [HttpGet("ObterUsuarioId")]
        public IActionResult ObterUsuarioId(int id)
        {
            return Ok("Usuário retornado com sucesso!");
        }

        [HttpPost]
        public IActionResult CadastrarUsuario()
        {
            return Ok("Usuário criado com sucesso!");
        }

        [HttpPut]
        public IActionResult AlterarUsuario()
        {
            return Ok("Usuário alterado com sucesso!");
        }
        [HttpDelete]
        public IActionResult DeleteUsuario()
        {
            return Ok("Usuário deletado com suceso!");
        }


    }
}
