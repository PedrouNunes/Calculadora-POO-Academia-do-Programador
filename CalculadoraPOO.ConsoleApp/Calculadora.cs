using System;

namespace CalculadoraPOO.ConsoleApp
{
    internal partial class Program
    {
        public class Calculadora
        {
            double resultadoOperacao = 0;
            Historico[] historico = new Historico[1000];

            public double Soma(double primeiroNumero, double segundoNumero)
            {
                resultadoOperacao = primeiroNumero + segundoNumero;

                Historico dados = new Historico();

                dados.numero1 = primeiroNumero;
                dados.numero2 = segundoNumero;
                dados.operacao = "Soma";
                dados.resultado = resultadoOperacao;
                
                for (int i = 0; i < historico.Length; i++)
                {
                    if (historico[i] == null)
                    {
                        historico[i] = dados;
                        break;
                    }
                }

                return resultadoOperacao;
           
            }

            public double Subtracao(double primeiroNumero, double segundoNumero)
            {
                resultadoOperacao = primeiroNumero - segundoNumero;

                Historico dados = new Historico();

                dados.numero1 = primeiroNumero;
                dados.numero2 = segundoNumero;
                dados.operacao = "Subtração";
                dados.resultado = resultadoOperacao;

                for (int i = 0; i < historico.Length; i++)
                {
                    if (historico[i] == null)
                    {
                        historico[i] = dados;
                        break;
                    }
                }

                return resultadoOperacao;
            }

            public double Divisao(double primeiroNumero, double segundoNumero)
            {
                resultadoOperacao = primeiroNumero / segundoNumero;

                Historico dados = new Historico();

                dados.numero1 = primeiroNumero;
                dados.numero2 = segundoNumero;
                dados.operacao = "Divisão";
                dados.resultado = resultadoOperacao;

                for (int i = 0; i < historico.Length; i++)
                {
                    if (historico[i] == null)
                    {
                        historico[i] = dados;
                        break;
                    }
                }

                return resultadoOperacao;
            }

            public double Multiplicacao(double primeiroNumero, double segundoNumero)
            {
                resultadoOperacao = primeiroNumero * segundoNumero;

                Historico dados = new Historico();

                dados.numero1 = primeiroNumero;
                dados.numero2 = segundoNumero;
                dados.operacao = "Multiplicacao";
                dados.resultado = resultadoOperacao;

                for (int i = 0; i < historico.Length; i++)
                {
                    if (historico[i] == null)
                    {
                        historico[i] = dados;
                        break;
                    }
                }

                return resultadoOperacao;
            }
                            
            public void HistoricoCalculadora()
            {
                for (int i = 0;i < historico.Length; i++)
                {
                    if (historico[i] != null)
                    {
                     Console.WriteLine(historico[i].operacao + ", entre " + historico[i].numero1 + " e " + historico[i].numero2 + ", resultado: " + Math.Round(historico[i].resultado), 2);
                     Console.WriteLine();
                    }
                }
            }
}
        }
            }

           
    

