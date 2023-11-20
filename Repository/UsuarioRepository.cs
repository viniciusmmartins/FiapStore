using FiapStore.Entity;
using FiapStore.Interface;

namespace FiapStore.Repository
{
    public class UsuarioRepository : DapperRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public override void Alterar(Usuario entidade)
        {
            throw new NotImplementedException();
        }

        public override void Cadastrar(Usuario entidade)
        {
            throw new NotImplementedException();
        }

        public override void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public override Usuario ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public override IList<Usuario> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
