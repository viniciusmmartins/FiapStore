using FiapStore.Entidade;

namespace FiapStore.Interface
{
    public interface IUsuarioRepository
    {
        IList<Usuario> ObterTodosUsuarios();
        Usuario ObterUsuarioPorId(int id);
        void CadastrarUsuario(Usuario usuario);
        void AlterarUsuario(Usuario usuario);
        void DeletarrUsuario(int id);

    }
}
