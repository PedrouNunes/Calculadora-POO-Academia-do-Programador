namespace CalculadoraPOO.ConsoleApp
{
    internal partial class Program
    {
        public class Calculadora
        {
            double resultadoOperacao = 0;

            public double Soma(double primeiroNumero, double segundoNumero)
            {
                resultadoOperacao = primeiroNumero + segundoNumero;
                return resultadoOperacao;
            }

            public double Subtracao(double primeiroNumero, double segundoNumero)
            {
                resultadoOperacao = primeiroNumero - segundoNumero;
                return resultadoOperacao;
            }

            public double Divisao(double primeiroNumero, double segundoNumero)
            {
                resultadoOperacao = primeiroNumero / segundoNumero;
                return resultadoOperacao;
            }

            public double Multiplicacao(double primeiroNumero, double segundoNumero)
            {
                resultadoOperacao = primeiroNumero * segundoNumero;
                return resultadoOperacao;
            }
                            
}
        }
            }

           
    

