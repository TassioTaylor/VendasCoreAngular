﻿using System;
using System.Collections.Generic;
using System.Text;
using VendasCoreAngular.Dominio.Enumerados;

namespace VendasCoreAngular.Dominio.ObjetoDeValor
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool IsBoleto
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Boleto; }
        }
        public bool IsCartaoCredito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.CartaoCredito; }
        }
        public bool IsDeposito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Deposito; }
        }
        public bool NaoDefinido
        {
            get { return Id == (int)TipoFormaPagamentoEnum.NaoDefinido; }
        }


    }
}
