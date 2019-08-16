using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace VendasCoreAngular.Dominio
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public ICollection<Entidades.Pedido> Pedidos  { get; set; }

    }
}
