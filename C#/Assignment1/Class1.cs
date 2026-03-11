using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    internal class Class1
    {
       public static void dividingtwoNumbers()
        {
            Console.Write("Enter first number: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double b = double.Parse(Console.ReadLine());

            if (b != 0)
                Console.WriteLine("Quotient = " + (a / b));
            else
                Console.WriteLine("Cannot divide by zero");
        }
    }
}
