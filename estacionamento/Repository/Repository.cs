using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Reflection;

namespace estacionamento.Repository
{
    public class Repository<T> : IRepository<T>
    {

        private readonly IDbConnection _conexão;
        public readonly string _nomeTabela;

        public Repository(IDbConnection conexão)
        {
            _conexão = conexão;
            _nomeTabela = ObterNomeTabela();
        }

        private string? ObterNomeTabela()
        {
            var tipo = typeof(T);
            var atributoTabela = tipo.GetCustomAttribute<TableAttribute>();
            if (atributoTabela != null)
            {
                return atributoTabela.Name;
            }
            return tipo.Name;

        }

        public void Atualizar(T entidade)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int Id)
        {
            throw new NotImplementedException();
        }

        public void Inserir(T entidade)
        {
            throw new NotImplementedException();
        }

        public T ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
