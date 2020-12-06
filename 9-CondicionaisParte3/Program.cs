using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_CondicionaisParte3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool foiPromovido = true;
            double salario = 0.0;


            if (foiPromovido)
            {
                salario = 4200.0;
            }
            else
            {
                salario = 3800.0;
            }

            Console.WriteLine(salario);

            Console.WriteLine("Pressione a tecla enter para finalizar o programa . . .");
            Console.ReadLine();
        }
    }
}
