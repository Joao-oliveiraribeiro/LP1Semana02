using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insira a altura do cilindro: ");
            string input = Console.ReadLine();
            double altura = double.Parse(input);

            Console.Write("Insira o raio do cilindro: ");
            string input2 = Console.ReadLine();
            double raio = double.Parse(input2);

            Console.Write("Insira o volume do cilindro: ");
            string input3 = Console.ReadLine();
            double volume = double.Parse(input3);

            
        }
    }
}
