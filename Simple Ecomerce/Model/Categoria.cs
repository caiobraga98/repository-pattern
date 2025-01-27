﻿using System.ComponentModel.DataAnnotations;

namespace Simple_Ecomerce.Model
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public ICollection<Produto> Produtos { get; set; }
    }
}
