using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando projeto 3 - Variaveis do tipo flutuante");


            double salario = 1700.20;

            double idade;

            idade = 15.0 / 2;
            Console.WriteLine(" 15.0 / 3 = " + idade);

            idade = 5 / 3;
            Console.WriteLine(" 5 / 3 = " + idade);

            idade = 5 / 3.0;
            Console.WriteLine(" 5 / 3.0 = " + idade);

            double peso = 4.0;

            int quantidade = 10;

            Console.WriteLine("O peso é: " + peso * quantidade);

            Console.WriteLine("Executando finalizada. Tecle enter para finalizar . . . ");
            Console.ReadLine();
        }
    }
}
