using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursosMacoratti
{
    class Program
    {
        static void Main(string[] args)
        {

            string escape = "\n";
            string escape1 = "\\" + "n";
            string escape2 = "\\n";

            Console.WriteLine(escape.Length);      // Existe apenas 1 caractere que é o de pular a linha
            Console.WriteLine(escape1.Length);     // São 2 caracteres, ele não se transforma em um escape
            Console.WriteLine(escape2.Length);     // São 2 caracteres, ele não se transforma em um escape

            var semeespace = @"\t significa um tab" + @"e \n significa uma nova linha";

            int n1, n2, n3;

            n1 = 10; n2 = 20; n3 = 30;

            Console.WriteLine("n1={0}, n2={1}, n3={2}", n1, n2, n3);

            Console.WriteLine("Pressione enter para finalizar o programa . . .");
            Console.ReadLine();


        }
    }
}
