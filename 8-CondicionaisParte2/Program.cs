﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_CondicionaisParte2
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 3300.0;

            if (salario < 2600.0)
                Console.WriteLine("A sua aliquota é de 15%");
            Console.WriteLine("Você pode deduzir até R$ 350");

            if (salario < 3750.0)
                Console.WriteLine("A sua aliquota é de 22,5%");
            Console.WriteLine("Você pode deduzir até R$ 636");

            Console.WriteLine("Pressione a tecla enter para finalizar o programa . . .");
            Console.ReadLine();
            
        }
    }
}
