using System;

namespace CalculadoraPOO.ConsoleApp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            Calculadora conta = new Calculadora();
            do
            {
                Console.WriteLine();
                do
                {
                    Console.WriteLine("Calculadora");
                    Console.WriteLine("Digite 1 para somar");

                    Console.WriteLine("Digite 2 para subtrair");

                    Console.WriteLine("Digite 3 para multiplicar");

                    Console.WriteLine("Digite 4 para dividir");

                    Console.WriteLine("Digite s para sair");
                    Console.Write("Resposta: ");
                    opcao = Console.ReadLine();

                }while(opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "s");


                if (opcao == "s")
                {
                    break;
                }


                Console.WriteLine();

                    Console.Write("Digite o primeiro número: ");
                    double primeiroNumero = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine();

                    Console.Write("Digite o segundo número: ");
                    double segundoNumero = Convert.ToDouble(Console.ReadLine());
                

                Console.WriteLine();

                if (opcao == "1")
                {
                    Console.Write("Resultado da soma: " + Math.Round(conta.Soma(primeiroNumero, segundoNumero), 2));
                }
                if (opcao == "2")
                {
                    Console.Write("Resultado da subtração: " + Math.Round(conta.Subtracao(primeiroNumero, segundoNumero), 2));
                }
                if (opcao == "3")
                {
                    Console.Write("Resultado da multiplicação: " + Math.Round(conta.Multiplicacao(primeiroNumero, segundoNumero), 2));
                }
                if (opcao == "4")
                {
                    Console.Write("Resultado da divisão: " + Math.Round(conta.Divisao(primeiroNumero, segundoNumero), 2));
                }
      

                Console.ReadLine();
            } while (opcao == "1" || opcao == "2" || opcao == "3" || opcao == "4" || opcao == "5");

            Console.WriteLine();
            Console.WriteLine("Histórico de Operações: ");
            conta.HistoricoCalculadora();
        }
    }
}
