using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 7 - Condicionais");

            System.Threading.Thread.Sleep(700);

            int idade = 0;
            bool idadeValida = false;

            while (idadeValida == false) {
                try
                {

                    idade = idadeJoao();
                    idadeValida = true;
                }
                catch(FormatException e) {

                    limpa();

                    Console.WriteLine("--------------ERRO 500--------------");
                    espera();
                    Console.WriteLine("\n*Não foi possível processar sua solicitação, devido ao seguinte erro: \n\n{0}\n", e.Message);

                    espera();
                    Console.WriteLine("--------------ERRO 500--------------");
                    espera();
                    Console.WriteLine("\n*O erro se apresenta da seguinte forma: \n\n{0}\n", e);

                    espera();

                    Console.WriteLine("--------------ERRO 500--------------");
                    Console.WriteLine("\nCaractere inválido, por favor insira um número entre 1-120 para prosseguir");
                    limpaEEspera();
                }
                catch
                {
                    Console.WriteLine("--------------ERRO 501--------------");
                    Console.WriteLine("Ocorre um erro não identificado");
                    limpaEEspera();
                }
            }

            if (idade != 0)
            {
                Console.WriteLine("\nA idade de João é {0}", idade);
            }

            Console.WriteLine("Pressione enter para finalizar o programa . . .");
            Console.ReadLine();

        }

        public static int idadeJoao()
        {
            var idade = "";
            int idadeInt = 0;
            Console.WriteLine("Digite a idade do João:");
            System.Threading.Thread.Sleep(100);

            idade = Console.ReadLine();

            idadeInt = Int32.Parse(idade);


            return idadeInt;
        }

        public static void limpa()
        {
            Console.Clear();
        }

        public static void limpaEEspera()
        {
            System.Threading.Thread.Sleep(4000);
            Console.Clear();
        }

        public static void espera()
        {
            System.Threading.Thread.Sleep(2000);
        }

    }
}
