using System;
using System.Data;

namespace Novo_Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int sair = 0;
                ContaBancaria conta = new ContaBancaria();
                ContaEspecial contaesp = new ContaEspecial(conta.Conta,1,1);
                while (sair == 0)
                {
                    ImprimeOpcoes();
                    int opcao = int.Parse(Console.ReadLine());
                    if (opcao == 0)
                    {
                        sair = 1;
                    }
                    else
                    {
                        if (opcao == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("======Abertura de nova conta=======");
                            Console.WriteLine("Digite o nome do novo correntista: ");
                            string nome = Console.ReadLine();
                            Console.WriteLine("Digite o valor do primeiro depósito: ");
                            float valor = float.Parse(Console.ReadLine());
                            conta = new ContaBancaria(nome, valor);
                            Console.WriteLine($" Numero da nova conta  é {conta.Conta} do {conta.Nome} saldo é de {conta.Saldo}");
                        }
                        if (opcao == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("======Abertura de nova conta Especaial=======");
                            Console.WriteLine("Digite o nome do novo correntista: ");
                            string nome = Console.ReadLine();
                            Console.WriteLine("Digite o valor do primeiro depósito: ");
                            float valor = float.Parse(Console.ReadLine());
                            Console.WriteLine("Digite o valor do limite: ");
                            float limite = float.Parse(Console.ReadLine());
                            contaesp = new ContaEspecial(nome, valor, limite);
                            Console.WriteLine($" Numero da nova conta  é {contaesp.Conta} do {contaesp.Nome} saldo é de {contaesp.Saldo} e o seu Limite {contaesp.Limite}");

                        }
                        else if (opcao == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("======Novo depósito=======");
                            Console.WriteLine("Digite o valor a ser depositado: ");
                            float valor = float.Parse(Console.ReadLine());
                            conta.Deposito(valor, DateTime.Now, "Deposito");
                            Console.WriteLine("Deposito realizado com sucesso! ");
                        }
                        else if (opcao == 4)
                        {
                            Console.Clear();
                            Console.WriteLine("======Novo Saque=======");
                            Console.WriteLine("Digite o valor a ser Sacado: ");
                            float valor = float.Parse(Console.ReadLine());
                            conta.Saque(valor, DateTime.Now, "Saque");
                            Console.WriteLine("Saque o realizado com sucesso! ");
                        }
                        else if (opcao == 5)
                        {
                            Console.Clear();
                            Console.WriteLine(conta.Extrato());
                        }
                        else if (opcao == 6)
                        {
                            Console.Clear();
                            Console.WriteLine("======Novo Saque=======");
                            Console.WriteLine("Digite o valor a ser Sacado: ");
                            float valor = float.Parse(Console.ReadLine());
                            contaesp.Saque(valor, DateTime.Now, "Saque");
                            Console.WriteLine($"Saque o realizado com sucesso! {System.DateTime.Now} Saldo {contaesp.Saldo} ");
                        }

                    }
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        static public void ImprimeOpcoes()
        {
            Console.WriteLine("============Opções==============");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Criar uma nova conta:");
            Console.WriteLine("2 - Criar uma nova conta Especial:");
            Console.WriteLine("3 - Fezer um Deposito");
            Console.WriteLine("4 - Fazer um Saque:");
            Console.WriteLine("5 - Tirar um Extrato");
            Console.WriteLine("6 - Saque conta especial");
            Console.WriteLine("================================");
            Console.WriteLine("Escolha uma das opções: ");

        }
    }
}
