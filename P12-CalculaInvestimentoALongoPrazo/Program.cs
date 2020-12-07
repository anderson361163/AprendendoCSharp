using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_CalculaInvestimentoALongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 11 - Calcula poupança a longo prazo");

            double valorInvestido = 1000;
            double fatorInvestimento = 1.0036;

            for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for (int contadorMes = 1; contadorMes <=12; contadorMes++)
                {
                    valorInvestido *= fatorInvestimento;
                }
                fatorInvestimento += 0.0010;
            }

            Console.WriteLine("Ao termino do investimento você terá {0}!", valorInvestido.ToString("C2"));
            Console.WriteLine("Pressione a tecla enter para finalizar o programa . . . ");
            Console.ReadLine();
        }
    }
}
