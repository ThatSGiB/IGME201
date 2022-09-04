using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter in the first number: ");
            string str1 = Console.ReadLine();
            int var1 = Convert.ToInt32(str1);
            Console.Write("Enter in the second number: ");
            string str2 = Console.ReadLine();
            int var2 = Convert.ToInt32(str2);
            if(var1 > 10 && var2 > 10)
            {
                Console.WriteLine("Error, both numbers cannot be greater than 10, please reenter numbers.");
                Console.Write("Enter in the first number: ");
                str1 = Console.ReadLine();
                var1 = Convert.ToInt32(str1);
                Console.Write("Enter in the second number: ");
                str2 = Console.ReadLine();
                var2 = Convert.ToInt32(str2);
            }
            else
            {
                Console.WriteLine(var1 + ", " + var2);
            }
        }
    }
}
