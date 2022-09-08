using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            // generate a random number between 0 inclusive and 101 exclusive
            int randomNumber = rand.Next(0, 101);
            Console.WriteLine("Test: "+ randomNumber);
            for(int i = 0; i < 8; i++)
            {
                Console.WriteLine("Please guess a number from 0 to 100: ");
                string str1 = Console.ReadLine();
                int num1 = Convert.ToInt32(str1);
                
                if(num1 < 0 || num1 > 100)
                {
                    Console.WriteLine("Invalid submission, guesses must be between 0 and 100.");
                }else if(num1 < randomNumber)
                {
                    Console.WriteLine("Your guess was too low.");
                }
                else if (num1 > randomNumber)
                {
                    Console.WriteLine("Your guess was too high.");
                }
                else if (num1 == randomNumber)
                {
                    Console.WriteLine("You guessed the number correctly!  Congratulations!");
                    Console.WriteLine("It took you " + (i+1) + " turn(s) to figure out the number!");
                    break;
                }
                if(i == 7)
                {
                    Console.WriteLine("Sorry!  You failed to guess the correct number.  The answer was: " + randomNumber);
                }
            }
        }
    }
}
