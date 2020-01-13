using System;

namespace Opgave5
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Indtast et tal der er større end 0 og mindre end 11.");
                string numberInput = Console.ReadLine();
                int.TryParse(numberInput, out int number);
                if(number > 0 && number < 11)
                {
                    Console.WriteLine($"Du skrev {number}, det er i korrekt interval, programmet lukker.");
                    break;
                }
                else
                {
                    Console.WriteLine("Prøv igen");
                }

            }
            
        }
    }
}
