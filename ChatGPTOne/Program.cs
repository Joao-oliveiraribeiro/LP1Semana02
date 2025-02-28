using System;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string question;
            bool cycle = true;

            while(cycle)
            {
                Console.WriteLine("En que posso ajudar?(Digite EXIT para sair)");
                question = Console.ReadLine();

                if (question == "EXIT")
                {
                    cycle = false;
                }
                else
                {
                    switch (question)
                    {
                        case "Como estás?":
                        Console.WriteLine("Estou bem obrigado por perguntar");
                        break

                         
                    }
                }
            }
        }
    }
}
