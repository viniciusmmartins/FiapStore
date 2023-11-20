﻿using Dapper;
using FiapStore.Entity;
using FiapStore.Interface;
using System.Data.SqlClient;

namespace FiapStore.Repository
{
    public class UsuarioRepository : DapperRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public override void Alterar(Usuario entidade)
        {
            using(var dbConnection = new SqlConnection(ConnectionString))
            {
                var query = "UPDATE USUARIO SET NOME = @Nome WHERE ID = @Id";
                dbConnection.Query(query,entidade);

            }
        }

        public override void Cadastrar(Usuario entidade)
        {
            using (var dbConnection = new SqlConnection(ConnectionString))
            {
                var query = "INSERT INTO USUARIO (NOME) VALUES(@Nome)";
                dbConnection.Execute(query, entidade);

            }
        }

        public override void Deletar(int id)
        {
            using (var dbConnection = new SqlConnection(ConnectionString))
            {
                var query = "DELETE FROM USUARIO WHERE ID = @Id";
                dbConnection.Execute(query, new {Id = id});

            }
        }

        public override Usuario ObterPorId(int id)
        {
            using (var dbConnection = new SqlConnection(ConnectionString))
            {
                var query = "SELECT * FROM USUARIO WHERE ID = @Id";
                return dbConnection.Query<Usuario>(query, new { Id = id })
                    .FirstOrDefault();
            }
        }

        public override IList<Usuario> ObterTodos()
        {
            using (var dbConnection = new SqlConnection(ConnectionString))
            {
                var query = "SELECT * FROM USUARIO";
                return dbConnection.Query<Usuario>(query).ToList();
            }
        }
    }
}
