using System;

namespace Opgave1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(i < 10)
            {
                Console.Write("While statement ");
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine($"Denne løkke har kørt {i} gange");
            Console.ReadLine();
        }
    }
}
