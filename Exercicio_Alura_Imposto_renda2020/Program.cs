using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Alura_Imposto_renda2020
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 2261.00;

            if (salario <= 1903.98)
            {
                Console.WriteLine("Você é isento do imposto de renda!");
            }
            else if(salario > 1903.99 && salario <= 2826.65)
            {
                Console.WriteLine("A sua aliquota é de 7,5%");
                Console.WriteLine("Você pode deduzir até R$ 142,80");
            }
            else if (salario > 2826.66 && salario <= 3751.05)
            {
                Console.WriteLine("A sua aliquota é de 15%");
                Console.WriteLine("Você pode deduzir até R$ 354,80");
            }
            else if (salario > 3751.06 && salario <= 4664.68)
            {
                Console.WriteLine("A sua aliquota é de 22,5%");
                Console.WriteLine("Você pode deduzir até R$ 636,13");
            }
            else if (salario > 4664.68)
            {
                Console.WriteLine("A sua aliquota é de 27,5%");
                Console.WriteLine("Você pode deduzir até R$ 869,36");
            }
            else
            {
                Console.WriteLine("ERRO");
            }

            Console.WriteLine(@"Referencia: https://www.gov.br/receitafederal/pt-br/assuntos/orientacao-tributaria/tributos/irpf-imposto-de-renda-pessoa-fisica");

            Console.WriteLine("Pressione a tecla enter para finalizar o programa . . .");
            Console.ReadLine();
        }
    }
}
