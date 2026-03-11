using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    internal class Class5
    {
        public static void HighestNumber()
        {
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }

        }
    }
}