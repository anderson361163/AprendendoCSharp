using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        public static string nome = "";

        static void Main(string[] args)
        {
            dividirConteudo();
            Console.WriteLine("Executando o projeto 7 - Condicionais\n");

            System.Threading.Thread.Sleep(700);

            Console.WriteLine("\nInsira o nome do usuário: ");

            nome = Console.ReadLine();
            var variavel = "";
            var acompString = "";

            int idade = 0;
            int idadeInt = 0;

            bool acomp = false;
            bool acompanhado = false;
            bool idadeValida = false;

            while (idadeValida == false)
            {
                try
                {
                    dividirConteudo();
                    Console.WriteLine("Digite a idade do(a) usuário(a) {0}:", nome);

                    espera();

                    variavel = Console.ReadLine();
                    idadeInt = Int32.Parse(variavel);
                    dividirConteudo();
                    Console.WriteLine("{0} está acompanhado(a)? (Digite: True / False)", nome);

                    espera();

                    acompString = Console.ReadLine();
                    acompanhado = bool.Parse(acompString);

                    idadeValida = true;
                }
                catch (FormatException e)
                {

                    limpa();

                    Console.WriteLine("--------------ERRO 500--------------");
                    Console.WriteLine("\n* Não foi possível processar sua solicitação, devido ao seguinte erro: \n\n{0}\n", e.Message);

                    espera();

                    Console.WriteLine("--------------ERRO 500--------------");
                    Console.WriteLine("\n* O erro se apresenta da seguinte forma: \n\n{0}\n", e);

                    espera();

                    Console.WriteLine("--------------ERRO 500--------------");
                    Console.WriteLine("\n* O tipo de exceção que ocorre foi: {0}", e.GetType());

                    espera();

                    Console.WriteLine("--------------ERRO 500--------------");
                    Console.WriteLine("\nPor favor tente novamente, inserindo um número entre 1 e 120 para prosseguir na idade do usuário.");
                    limpaEEspera();
                }
                catch
                {
                    Console.WriteLine("--------------ERRO 501--------------");
                    Console.WriteLine("Ocorre um erro não identificado");
                    limpaEEspera();
                }
            }

            if (idade >= 18 || acomp == false)
            {
                dividirConteudo();
                Console.WriteLine("\n{0} pode entrar por atender um dos requisitos de maioridade OU minoridade com acompanhamente.", nome, idade);
            }
            else
            {
                dividirConteudo();
                Console.WriteLine("\n{0} não possui idade igual ou superior a 18 anos. Não pode entrar!", nome);
            }

            dividirConteudo();
            Console.WriteLine("\nPressione enter para finalizar o programa . . .");
            Console.ReadLine();

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

        public static void dividirConteudo()
        {
            Console.WriteLine("----------------");
        }

        public static void espera()
        {
            System.Threading.Thread.Sleep(2000);
        }

    }
}
