using System;

namespace Specials
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello, World!");
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(short.MaxValue);
            Console.WriteLine(short.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(ushort.MaxValue);
            Console.WriteLine(ushort.MinValue);
            Console.WriteLine(uint.MaxValue);
            Console.WriteLine(uint.MinValue);
            Console.WriteLine(ulong.MaxValue);
            Console.WriteLine(ulong.MinValue);
            Console.WriteLine(char.MaxValue);
            Console.WriteLine(char.MinValue);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(double.PositiveInfinity);
            Console.WriteLine(double.NegativeInfinity);
            Console.WriteLine(float.PositiveInfinity);
            Console.WriteLine(float.NegativeInfinity);
            Console.WriteLine(double.PositiveInfinity / double.PositiveInfinity);
            Console.WriteLine(float.NaN);
            int x = sbyte.MaxValue;
            Console.WriteLine((sbyte)(x+1));
            int y = short.MaxValue;
            Console.WriteLine((short)(y+1));
            int z = byte.MaxValue;
            Console.WriteLine((byte)(z+1));
            double a = 2* double.MaxValue;
            Console.WriteLine(a);
            double b = double.MaxValue +1;
            Console.WriteLine(b);
            float c = 2* float.MaxValue;
            Console.WriteLine(c);
            float d = float.MaxValue;
            Console.WriteLine((float)(d+1));

        }
    }
}
