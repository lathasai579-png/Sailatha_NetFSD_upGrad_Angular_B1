using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    internal class Class7
    {
       public static void JourneyTime()
        {
            Console.Write("Enter distance: ");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter speed: ");
            double speed = Convert.ToDouble(Console.ReadLine());

            if (speed != 0)
                Console.WriteLine("Time taken = " + (distance / speed));
            else
                Console.WriteLine("Speed cannot be zero");
        }

    }
}
