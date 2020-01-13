using System;

namespace Opgave6
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Skriv '1' for at høre noget om køer");
                Console.WriteLine("Skriv '2' for at få resultatet af 2*4");
                Console.WriteLine("Skriv '3' for at afslutte programmet");
                string input = Console.ReadLine();
                if(input == "1")
                {
                    Console.WriteLine("Køer har 4 ben og er lavet af bøf");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if(input == "2")
                {
                    Console.WriteLine("2*4 = 8");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if(input == "3")
                {
                    Console.WriteLine("Farvel");
                    break;
                }
                else
                {
                    Console.WriteLine("Ugyldigt Input! Prøv igen");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            
        }
    }
}
