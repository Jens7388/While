using System;

namespace Opgave3
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                int counter = 0;
                int singleLetters = 0;

                Console.Write("Indtast en kort tekst:");
                string text = Console.ReadLine();
                while(counter < text.Length)
                {
                    //udsrkiver hvert enkelt bogstav på sin egen linje
                    Console.WriteLine(text.Substring(singleLetters,1));
                    singleLetters++;
                    counter++;
                }
                Console.ReadLine();
                Console.Clear();
            }
            
        }
    }
}
