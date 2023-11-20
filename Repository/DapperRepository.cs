﻿using FiapStore.Entity;
using FiapStore.Interface;

namespace FiapStore.Repository
{
    public abstract class DapperRepository<T> : IRepository<T> where T : Entidade

    {

        private readonly string _connectionString;
        protected string ConnectionString => _connectionString;


        public DapperRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetValue<string>("ConnectionString:ConnectionString");              
        }


        public abstract void Alterar(T entidade);

        public abstract void Cadastrar(T entidade);

        public abstract void Deletar(int id);

        public abstract IList<T> ObterTodos();

        public abstract T ObterPorId(int id);
    }
}
