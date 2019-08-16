using System;
using System.Collections.Generic;
using System.Text;

namespace VendasCoreAngular.Dominio.Entidades
{
    public class Produto
    {
        public int ind { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
    }
}
