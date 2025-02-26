using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insira a altura do cilindro: ");
            string input = Console.ReadLine();
            double a = double.Parse(input);

            Console.Write("Insira o raio do cilindro: ");
            string input2 = Console.ReadLine();
            double r = double.Parse(input2);

            double V = Math.PI * Math.Pow(r, 2) * a;

            double Sa = 2 * Math.PI * r * (r + a);

            Console.WriteLine ($"{V:f3}");

            Console.WriteLine ($"{Sa:f3}");

        }
    }
}
