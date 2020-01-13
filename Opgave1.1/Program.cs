using System;

namespace Opgave1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int whileCounter = 0;
            while(i > 0)
            {
                Console.Write("While statement ");
                Console.WriteLine(i);
                i--;
                whileCounter++;
            }
            Console.WriteLine($"Denne løkke har kørt {whileCounter} gange");
            Console.ReadLine();
        }
    }
}
