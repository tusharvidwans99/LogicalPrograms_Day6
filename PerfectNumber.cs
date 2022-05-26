using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs_Day6
{
    /// <summary>
    /// This program is used to find the perfect number between range.
    /// </summary>
    public class PerfectNumber
    {
        public static void findPerfectNumber()
        {
            int min, max, n, sum;
            Console.Write("Enter the starting range: ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the ending range: ");
            max = Convert.ToInt32(Console.ReadLine());
            
            for (int i = min; i <= max; i++)
            {
                n = 1;
                sum = 0;
                while (n < i)
                {
                    if(i%n == 0)
                    {
                        sum += n;
                    }
                    n++;
                }
                if(sum == i)
                {
                    Console.WriteLine($"{i}");
                }
            }
        
        
        }
    }
}
