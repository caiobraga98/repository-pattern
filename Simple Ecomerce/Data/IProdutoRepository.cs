using Simple_Ecomerce.Model;

namespace Simple_Ecomerce.Data
{
    public interface IProdutoRepository
    {
        Task<IList<Produto>> ObterTodos();
        Task<Produto> ObterPorId(int id);
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Produto produto);
    }
}
