using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    internal class Class8
    {
       public static void ThirdCharCheck()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            if (str.Length >= 3)
            {
                char ch = Char.ToLower(str[2]);

                if ("aeiou".Contains(ch))
                    Console.WriteLine("Third character is Vowel");
                else
                    Console.WriteLine("Third character is Consonant");
            }
            else
            {
                Console.WriteLine("String must contain at least 3 characters");
            }
        }
    }
}
