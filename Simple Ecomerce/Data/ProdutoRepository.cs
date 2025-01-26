using Microsoft.EntityFrameworkCore;
using Simple_Ecomerce.Model;

namespace Simple_Ecomerce.Data
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly DataContext _context;
        public ProdutoRepository(DataContext context)
        {
            _context = context;
        }
        public async Task Adicionar(Produto produto)
        {
            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();
        }

        public async Task Atualizar(Produto produto)
        {
            _context.Produtos.Update(produto);
            await _context.SaveChangesAsync();
        }

        public async Task<Produto> ObterPorId(int id)
        {
            try
            {
                return await _context.Produtos.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IList<Produto>> ObterTodos()
        {
            return await _context.Produtos.ToListAsync();
        }

        public async Task Remover(Produto produto)
        {
            _context.Produtos.Remove(produto);
            await _context.SaveChangesAsync();
        }
    }
}
