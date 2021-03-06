﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VendasCoreAngular.Dominio.ObjetoDeValor;

namespace VendasCoreAngular.Dominio.Entidades
{
   public class Pedido : Entidade
    {
        public int id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioID { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public string NumeroEndereco { get; set; }

        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }

        public ICollection<ItemPedido> ItensPedidos { get; set; }

        public override void Validate()
        {
            LimparMensagensValidadcao();

            if (!ItensPedidos.Any())
                AdicionarCritica("Crítica - Pedido não pode ficar sem Item");
            if (string.IsNullOrEmpty(CEP))
                AdicionarCritica("Crítica - Cep deve estar preenchido");

        } 
    }
}
