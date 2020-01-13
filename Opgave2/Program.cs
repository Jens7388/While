using System;

namespace Opgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                int numberCounter = 0;
                int result = 0;
                while(numberCounter <= 4)
                {
                    //tast 1 tal ind af gangen, de bliver lagt sammen undervejs
                    Console.Write("Indtast et tal:");
                    switch(numberCounter)
                    {
                        case 0:
                            string firstNumberInput = Console.ReadLine();
                            int.TryParse(firstNumberInput, out int firstNumber);
                            result += firstNumber;
                            break;
                        case 1:
                            string secondNumberInput = Console.ReadLine();
                            int.TryParse(secondNumberInput, out int secondNumber);
                            result += secondNumber;
                            break;
                        case 2:
                            string thirdNumberInput = Console.ReadLine();
                            int.TryParse(thirdNumberInput, out int thirdNumber);
                            result += thirdNumber;
                            break;
                        case 3:
                            string fourthNumberInput = Console.ReadLine();
                            int.TryParse(fourthNumberInput, out int fourthNumber);
                            result += fourthNumber;
                            break;
                        case 4:
                            string fifthNumberInput = Console.ReadLine();
                            int.TryParse(fifthNumberInput, out int fifthNumber);
                            result += fifthNumber;
                            break;
                        default:
                            break;
                    }
                    numberCounter++;
                }
                Console.WriteLine($"Resultatet af tallene er: {result}");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
