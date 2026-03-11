using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    internal class class4
    {
       public static void OddOrEven()
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
                Console.WriteLine("Even Number");
            else
                Console.WriteLine("Odd Number");
        }

    }
}
