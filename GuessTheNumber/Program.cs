using System;
using System.Runtime.InteropServices.Marshalling;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Random rnd= new Random();
            int numberToGuess = rnd.Next(31);


            
            bool cycle =true;
            while (cycle);
            (
                Console.WriteLine("Insert number: ");
                string num = Console.ReadLine();
                int num1 = int.Parse(num);

                if (num1 == numberToGuess)
                {
                Console.WriteLine("You found the hidden number " + numberToGuess);
                cycle = false;
                }
                else if (num1 < 0)
                {
                Console.WriteLine("Numbers must be between 0 and 30. Try again") ;
                }
                else if (num1 > 30)
                {
                Console.WriteLine("Numbers must be between 0 and 30. Try again") ;
                }
                else if (num1 > numberToGuess)
                {
                Console.WriteLine("The hidden number is lower than " + num1 +". Try again") ;
                }
                else if (num1 < numberToGuess)
                {
                Console.WriteLine("The hidden number is higher than " + num1 +". Try again") ;
                }
            )
        }
    }
}
