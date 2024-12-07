using System.ComponentModel.DataAnnotations;

namespace Simple_Ecomerce.Model
{
    public class Produto
    {
        [Key]
        public int id { get; set; }

        public string nome { get; set; }

        public string descricao { get; set; }

        public double preco { get; set; }
    }
}
