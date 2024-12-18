using Microsoft.EntityFrameworkCore;
using Simple_Ecomerce.Model;

namespace Simple_Ecomerce.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        //dbcontext representa a sessão com o banco de dados sendo a ponto entra as entidades de domínio e o banco de dados.
        //DbSet representa uma coleção de entidades que serão mapeadas para o banco de dados.
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
