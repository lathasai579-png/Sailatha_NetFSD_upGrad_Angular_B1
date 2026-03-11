using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    internal class class2
    {
       public static void KmToMeters()
        {
            Console.Write("Enter distance in KM: ");
            double km = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Meters = " + (km * 1000));
        }
    }
}
