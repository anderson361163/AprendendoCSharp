using System;

namespace _0._2_CFBCursosMacoratti
{
    class Program
    {

        static void Main(string[] args)
        {
            int v1, v2, soma;
            string nome;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            v1 = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Digite o segundo valor: ");
            v2 =Convert.ToInt32(Console.ReadLine());

            soma = v1 + v2;
            
            Console.WriteLine("O resultado da soma é {0}", soma);

            Console.WriteLine("Seu nome é: {0}", nome);

            Console.WriteLine("Pressione enter para finalizar o programa . . .");
            Console.ReadLine();
        }
    }
}
