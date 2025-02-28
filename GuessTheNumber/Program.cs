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

            while(cycle)
            {
                Console.Write("Insert number: ");
                int input_number = int.Parse(Console.ReadLine());

                if(numberToGuess == input_number)
                {
                    Console.WriteLine($"You found the hidden number {input_number} after {tries} tries.");
                    cycle = false;



