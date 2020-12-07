using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P16_MultiplosDe3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplos de 3!\n");
            for (int i = 3; i<100; i=i+3)
            {
               // if(i % 3 == 0)
               // {
                    Console.WriteLine(i);
               // }
            }
            Console.ReadLine();
        }
    }
}
