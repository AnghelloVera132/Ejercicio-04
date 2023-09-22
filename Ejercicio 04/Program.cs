﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Ingrese el número limíte: ");
            int limite = int.Parse(Console.ReadLine());
            Console.WriteLine("============================");
            Console.WriteLine("Escoja una opción: ");
            Console.WriteLine("1: Números pares");
            Console.WriteLine("2: Números impares");
            Console.WriteLine("3: Factorial");
            Console.Write("->");
            int Texto = int.Parse(Console.ReadLine());
            long num = 1;
            switch (Texto)
            {
                case 1:
                    for (int i = 1; i <= limite; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write(i + ", ");  
                        }
                    }
                    break;

                case 2:
                    for (int i = 1; i <= limite; i+=2)
                    {
                        Console.Write(i + ", ");
                    }
                    break;

                case 3:
                    for (int i = 1; i <= limite; i++)
                    {
                        num = num * i;
                    }
                    Console.WriteLine($"El factorial es "+ num);
                    break; 
            }
            Console.ReadKey();
        }
    }
}
