using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {

            dividirConteudo();

            char letra = 'a';
            Console.WriteLine(letra);

            espera();

            dividirConteudo();

            char valor = (char)65;
            Console.WriteLine(valor);

            espera();

            dividirConteudo();

            valor = (char)(valor + 1);         
            Console.WriteLine(valor);

            espera();

            dividirConteudo();

            string palavra = "Alura cursos online de tecnologia ";
            Console.WriteLine(palavra);

            espera();

            dividirConteudo();

            palavra = palavra + 2020;
            Console.WriteLine(palavra);

            espera();

            dividirConteudo();

            string pLinguagens = @"   Principais Linguagens da Microsoft:
                                   * C#;
                                   * VB;
                                   * C++.";

            Console.WriteLine(pLinguagens);

            dividirConteudo();

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
