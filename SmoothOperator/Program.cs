using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insere número inteiro: ");
            string input = Console.ReadLine();
            sbyte n = sbyte.Parse(input);

            Console.WriteLine(--n);
            Console.WriteLine(++n);


            
        }
    }
}
