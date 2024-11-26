namespace estacionamento.Repository
{
    public interface IRepository<T>
    {
        IEnumerable<T> ObterTodos();
        T ObterPorId (int id);
        void Inserir (T entidade);
        void Atualizar(T entidade);
        void Excluir(int Id);

    }
}
