using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 10 - Calcula poupança");

            double valorInvestido = 1000;
            for (int i =1; i <= 12; i++)
            {   
                valorInvestido *= 1.0036;
                Console.WriteLine("Após {0} meses, você terá {1} aplicados.", i, valorInvestido.ToString("C3"));
            }

            Console.WriteLine("Pressione a tecla enter para finalizar o programa . . . ");
            Console.ReadLine();
        }
    }
}
