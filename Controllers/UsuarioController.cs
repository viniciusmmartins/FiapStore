using FiapStore.Entity;
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
            return Ok(_usuarioRepository.ObterTodos());
        }

        [HttpGet("Obter-Usuario-Por-Id/{id}")]
        public IActionResult ObterUsuarioId(int id)
        {
            return Ok(_usuarioRepository.ObterPorId(id));
        }

        [HttpPost]
        public IActionResult CadastrarUsuario(Usuario usuario)
        {
            _usuarioRepository.Cadastrar(usuario);
            return Ok("Usuário cadastrado com sucesso!");
        }

        [HttpPut]
        public IActionResult AlterarUsuario(Usuario usuario)
        {
            _usuarioRepository.Alterar(usuario);
            return Ok("Usuário alterado com sucesso!");
        }
        [HttpDelete ("{id}")]
        public IActionResult DeleteUsuario(int id)
        {
            _usuarioRepository.Deletar(id);
            return Ok("Usuário deletado com suceso!");
        }


    }
}
