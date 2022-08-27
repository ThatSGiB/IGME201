using System;

namespace SquashTheBugs
{
    // Class Program
    // Author: David Schuh
    // Purpose: Bug squashing exercise
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        //          Output N/(N-1) for all 10 numbers
        //          and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare int counter
            //int i = 0
            //Didn't have ;, and doesn't need to equal anything yet, as it will be issued a value later
            int i;
            string allNumbers = null;

            // loop through the numbers 1 through 10
            for (i = 1; i < 10; ++i)
            {
                // declare string to hold all numbers
                //string allNumbers = null;
                //Was in the wrong location, needed to be before the loop in order for it to be used outside of the loop

                // output explanation of calculation
                //Console.Write(i + "/" + i - 1 + " = ");
                //Was attempting to combine strings and integers, so put "" around -1 so that it wouldn't try to do that
                Console.Write(i + "/" + i + "- 1" + " = ");

                // output the calculation based on the numbers
                //Console.WriteLine(i / (i - 1));
                //Created an if statement to skip this calculation running 1 because it would otherwise divide by 0
                if (i == 1)
                { } 
                else if(i > 1)
                { Console.WriteLine(i / (i - 1)); }
                

                // concatenate each number to allNumbers
                allNumbers += i + " ";

                // increment the counter
                i = i + 1;
            }

            // output all numbers which have been processed
            Console.WriteLine("These numbers have been processed: ", allNumbers);
        }
    }
}
