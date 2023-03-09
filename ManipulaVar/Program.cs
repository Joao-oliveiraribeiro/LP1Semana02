using System;

namespace ManipulaVar
{
    class Program
    {
        static void Main(string[] args)
        
        {
            Console.WriteLine("Hello, World!");
            int x= int.Parse(args[0]);
            x++;
            Console.WriteLine(x);
            --x;
            --x;
            Console.WriteLine(x);
        }
    }
}
