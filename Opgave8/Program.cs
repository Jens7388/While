using System;

namespace Opgave8
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                bool run = true;
                do
                {
                    //genererer to tilfældige tal mellem 1 og 10
                    Random randomNumber = new Random();
                    int firstNumber = randomNumber.Next(1, 11);
                    int secondNumber = randomNumber.Next(1, 11);
                    Console.WriteLine($"Hvad er resultatet af {firstNumber} + {secondNumber} ?");
                    bool correct;
                    //lav ikke nye regnestykker så længe at svaret ikke er korrekt
                    do
                    {
                        string answerInput = Console.ReadLine();
                        int.TryParse(answerInput, out int answer);
                        int result = firstNumber + secondNumber;
                        correct = answer == result;
                        if(correct)
                        {
                            Console.WriteLine("Korrekt!");
                        }
                        else if(answerInput == "q")
                        {
                            Environment.Exit(0);
                        }
                        else if(answerInput == "")
                        {
                            Console.WriteLine("Du har ikke indtastet noget..");
                        }
                        else
                        {
                            Console.WriteLine("Forkert! Prøv igen.");
                            Console.WriteLine($"Hvad er resultatet af {firstNumber} + {secondNumber} ?");
                        }
                    } while(!correct);
                } while(run);
            }
        }
    }
}
