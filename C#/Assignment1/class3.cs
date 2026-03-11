using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    internal class class3
    {
       public static void SumAndAverage()
        {
            double sum = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Enter number " + i + ": ");
                sum += Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Average = " + (sum / 5));
        }
    }
}
