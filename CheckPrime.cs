using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs_Day6
{
    /// <summary>
    /// This program is used to check a given number is prime or not.
    /// </summary>
    public class CheckPrime
    {
        public static void isPrime()
        {
            int status = 1;
            Console.Write("Enter the number to check it is Prime or Not: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i = 2; i < num; i++)
            {
                if(num%i == 0)
                {
                    Console.WriteLine($"{num} is not a prime number");
                    status = 0;
                    break;
                }
            }
            if (status == 1)
            {
                Console.WriteLine($"{num} is the Prime Number");
            }

        }

    }
}
