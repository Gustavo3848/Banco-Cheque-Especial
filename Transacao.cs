﻿
using System;
using System.Collections.Generic;
using System.Text;

namespace Novo_Banco
{
    class Transacao
    {
        public float Valor { get; }
        public DateTime Data { get; }
        public string Obs { get; }

        public Transacao(float valor, DateTime data, string obs)
        {
            this.Valor = valor;
            this.Data = data;
            this.Obs = obs;
        }

    }
}