using System;

namespace ChatGPTMother
{
    class Program
    {
        static void Main(string[] args)
        {
            // iNITIALIZING CICLE
            while (true)
            {
                // Question detection
                string question;
                Console.WriteLine("What is your question?");
                question = Console.ReadLine();
                if (question != "EXIT")
                {

                    // Choose response
                    string response = question switch
                    {
                        "What are you" => "Im a bot",
                        "What do you do?" => "I respond to questions",
                        "How do I stop you?" => "Write EXIT", 
                        _ => "I m too dumb to recognize that question",
                    };
                    Console.WriteLine(response);
                }
                // Cicle break
                if (question == "EXIT")
                {
                    break;
                }
            }        
        }
    }
}
