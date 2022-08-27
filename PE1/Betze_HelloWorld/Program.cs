//Spencer Betze, PE1: Hello World, 8/24/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Betze_HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Had the console write my name like in the instructions
            Console.WriteLine("Spencer Betze");
            //created variables using var, it seems that let does not work in this
            var x = 4;
            var y = 6;
            //Console prints the answer of the equation, and prints exactly what is written in quotes, regardless of what it once was
            Console.WriteLine(x + y);
            Console.WriteLine("x + y");
            //If and for statements seem to work exactly the same as in JS, using int instead of let
            if (x == 4)
            {
                for(int i= 0; i<= y; i++)
                {
                    Console.WriteLine(i * (x + y));
                }
            }
        }
    }
}
