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
                        break;

                        case "O que és?":
                        Console.WriteLine("Sou o bot concebido para tentar responder as suas questões");
                        break;

                        case "Em que linguagem corres?":
                        Console.WriteLine("O meu código é feito em C#");
                        break;

                        case "Consegues dar opiniões?":
                        Console.WriteLine("Não estou preparado para essa característica humana");
                        break;

                        default;
                            Console.WriteLine("Não consigo responder a essa pergunta");
                            break;

                         
                    }
                }
            }
        }
    }
}
