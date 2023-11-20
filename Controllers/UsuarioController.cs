using Microsoft.AspNetCore.Mvc;

namespace FiapStore.Controllers
{
    public class UsuarioController : ControllerBase
    {
        [HttpGet]

        public IActionResult ObterUsuario()
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
