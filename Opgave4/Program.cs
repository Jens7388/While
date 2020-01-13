using System;

namespace Opgave4
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Skriv 'exit' for at afslutte programmet");
            Console.WriteLine("Skriv noget, og få det gentaget");
            string input = "";
            while(input != "exit")
            {
                input = Console.ReadLine().ToLower();
                Console.WriteLine(input);
            }
        }
    }
}
