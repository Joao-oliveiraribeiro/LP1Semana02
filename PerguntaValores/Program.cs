using System;

namespace PerguntaValores
{
    class Program
    {
        static void Main(string[] args)
        {
            double π = 3.1415926;
            double a;
            double r;
            double V;
            Console.WriteLine("What is the height of your cilinder?");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the radius of your cilinder?");
            r = Convert.ToDouble(Console.ReadLine());
            V = π * (r*r) * a;
            Console.WriteLine(V);
        }
    }
}
