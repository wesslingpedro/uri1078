﻿using System;
using System.Globalization;

namespace testes_ec
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            N = int.Parse(Console.ReadLine());

            for (int i=1; i <=10; i++)
            {
                int resultado = i * N;
                Console.WriteLine(i + " x " + N + " = " + resultado);
                

            }




        }

    }

}