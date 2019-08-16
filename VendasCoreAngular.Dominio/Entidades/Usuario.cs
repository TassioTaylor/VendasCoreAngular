using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using VendasCoreAngular.Dominio.Entidades;

namespace VendasCoreAngular.Dominio
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public ICollection<Entidades.Pedido> Pedidos  { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
