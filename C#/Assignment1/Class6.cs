using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    internal class Class6
    {
       public static void AreasOfRecandSqu()
        {
            Console.Write("Enter length of rectangle: ");
            double l = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter breadth of rectangle: ");
            double br = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Area of Rectangle = " + (l * br));

            Console.Write("Enter side of square: ");
            double s = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Area of Square = " + (s * s));
        }

    }
}
