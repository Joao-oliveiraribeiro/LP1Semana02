﻿using System;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insere número inteiro-não negativo: ");
            string input = Console.ReadLine();
            byte n = byte.Parse(input);

            Console.WriteLine(n / 2);
            Console.WriteLine(n << 3);
            Console.WriteLine(n ^ 6);
            Console.WriteLine(n > 10);
        }
    }
}
