using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Progams_Day6
{
    /// <summary>
    /// This program is used to revesed the given number. 
    /// </summary>
    public class ReverseNumber
    {
        public static void reverseTheNumber()
        {
            int number, reverse, remainder;
            Console.Write("Enter the numbe to reverse it: ");
            number = Convert.ToInt32(Console.ReadLine());
            reverse = 0;
            Console.WriteLine($"Original NUmber: {number}");
            while (number != 0)
            {
                remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number /= 10;
                
            }
            Console.WriteLine("Reverse version: " + reverse);
        }
    }
}
