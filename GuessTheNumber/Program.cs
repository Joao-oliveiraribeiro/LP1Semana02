using System;
using System.Security.Cryptography.X509Certificates;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Random rnd = new Random();
            int numberToGuess = rnd.Next(31);

            bool cycle = true;
            int tries = 1;

            while (cycle)
            {
                Console.Write("Insert number: ");
                int input_number = int.Parse(Console.ReadLine());

                if (numberToGuess == input_number)
                {
                    Console.WriteLine($"You found the hidden number {input_number} after {tries} tries.");
                    cycle = false;

                }
                if (input_number < 0 || input_number > 30)
                {
                    Console.WriteLine("Numbers must be between 0 and 30. Try again.");
                    tries++;
                    continue;
                }
                if (numberToGuess > input_number)
                {
                    Console.WriteLine($"The hidden number is higher than {input_number}. Try again.");
                    tries++;
                    continue;
                }
                if (numberToGuess < input_number)
                {
                    Console.WriteLine($"The hidden number is lower than {input_number}. Try again.");
                    tries++;
                    continue;
                }




            }
        }
    }
}

