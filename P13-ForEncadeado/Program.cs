using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            //*
            //**
            //***
            //****
            //*****
            //******
            
            //ESCREVENDO ASTERISCOS COM BREAK
            for (int contadorLinha = 0;contadorLinha < 10; contadorLinha++)
            {
                
                for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    Console.Write("*");
                    if(contadorColuna >= contadorLinha)
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }

            //ESCREVENDO ASTERISCOS COM BREAK
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {

                for (int contadorColuna = 0; contadorColuna < contadorLinha; contadorColuna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Pressione enter para finalizar a aplicação");
            Console.ReadLine();
        }
    }
}
