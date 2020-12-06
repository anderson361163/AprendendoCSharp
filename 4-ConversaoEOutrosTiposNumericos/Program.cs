using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversaoEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {

            double salario;
            salario = 1200.50;

            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;

            dividirConteudo();

            Console.WriteLine("Convertendo salario de Double para Inteiro:");
            Console.WriteLine(salarioEmInteiro);

            espera();
            dividirConteudo();

            float salario2 = 1270.50f;
            int valor = (int)salario2;

            Console.WriteLine("Convertendo salario2 de Float para inteiro: ");
            Console.WriteLine(valor);

            espera();
            dividirConteudo();

            double valor1 = 0.2;
            double valor2 = 0.1;
            double total = valor1 + valor2;

            Console.WriteLine("Operação aritmética de soma: ");
            Console.WriteLine(total);

            espera();
            dividirConteudo();

/*          ----------Comentando código de multiplas linhas-----------
            Console.WriteLine("Operação aritmética de soma: ");
            int valor3 = (int)salario2;
            Console.WriteLine(valor3);
*/
            
            Console.WriteLine("Pressione enter para finalizar o programa . . .");
            Console.ReadLine();

        }
        private static void espera()
        {
            System.Threading.Thread.Sleep(2000);
        }

        private static void dividirConteudo()
        {
            Console.WriteLine("-----------------");
        }
    }
}
