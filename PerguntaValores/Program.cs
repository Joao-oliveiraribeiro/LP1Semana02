using System;

namespace PerguntaValores
{
    class Program
    {
        static void Main(string[] args)
        {
            double π = Math.PI;
            double a;
            double r;
            double V;
            double S;
            Console.WriteLine("What is the height of your cilinder?");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the radius of your cilinder?");
            r = Convert.ToDouble(Console.ReadLine());
            V = π * Math.Pow(r,r) * a;
            S = 2*π*r*(r+a);
            Console.WriteLine(V);
            Console.WriteLine(S);
        }
    }
}
