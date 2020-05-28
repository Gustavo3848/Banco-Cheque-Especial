using System;
using System.Collections.Generic;
using System.Text;

namespace Novo_Banco
{

    class ContaEspecial : ContaBancaria
    {
        public float Limite { get; private set; }
     

        public ContaEspecial(string nome, float valorInicial, float Limite) : base(nome, valorInicial)
        {
            
            this.Limite = Limite;
        }
        public override void Saque(float valor, DateTime data, string obs)
        {
            if (valor < (this.Saldo+this.Limite))
            {
                var saque = new Transacao(-valor, data, obs);
                todasTranscoes.Add(saque);
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(valor), "Limite de cheque especial atingido !!");
            }
        }

        public override string Extrato()
        {
            var extrato = new System.Text.StringBuilder();
            float total = 0;
            extrato.AppendLine("Data\t\tValor\ttotal\tOperação");
            foreach (var item in todasTranscoes)
            {
                total += item.Valor;
                extrato.AppendLine($"{item.Data.ToShortDateString()}\t{item.Valor}\t{total}\t{item.Obs}\t{this.Limite}");
            }
            return extrato.ToString();
        }
    }
}
