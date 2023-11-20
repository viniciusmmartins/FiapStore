using FiapStore.Entidade;
using FiapStore.Interface;
using Microsoft.AspNetCore.Mvc;

namespace FiapStore.Controllers
{
    
    [ApiController]
    [Route("Usuario")]
    
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioReposity)
        {
            _usuarioRepository = usuarioReposity;           
        }


        [HttpGet ("ObterTodosUsuarios")]
        public IActionResult ObterUsuarios()
        {
            return Ok(_usuarioRepository.ObterTodosUsuarios());
        }

        [HttpGet("Obter-Usuario-Por-Id/{id}")]
        public IActionResult ObterUsuarioId(int id)
        {
            return Ok(_usuarioRepository.ObterUsuarioPorId(id));
        }

        [HttpPost]
        public IActionResult CadastrarUsuario(Usuario usuario)
        {
            _usuarioRepository.CadastrarUsuario(usuario);
            return Ok("Usuário cadastrado com sucesso!");
        }

        [HttpPut]
        public IActionResult AlterarUsuario(Usuario usuario)
        {
            _usuarioRepository.AlterarUsuario(usuario);
            return Ok("Usuário alterado com sucesso!");
        }
        [HttpDelete ("{id}")]
        public IActionResult DeleteUsuario(int id)
        {
            _usuarioRepository.DeletarrUsuario(id);
            return Ok("Usuário deletado com suceso!");
        }


    }
}
