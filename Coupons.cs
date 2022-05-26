using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Progams_Day6
{
    /// <summary>
    /// This Program will give Unique Coupon Numbers.
    /// </summary>
    public class Coupons
    {

        static Random random = new Random();
        public static void FindNewCoupon()
        {
            Console.WriteLine("Enter how many unique coupons do you want: ");
            int number=Convert.ToInt32(Console.ReadLine());
            distinctCoupon(number);

        }

        public static void generateCoupon()
        {
            double coupon = (random.NextDouble()*1000000);
            Console.WriteLine((int)coupon);

        }

        public static void distinctCoupon(int number)
        {
            Console.WriteLine("Unique Coupns are ");

            while (number > 0)
            {
                generateCoupon();
                number--;
            }
        }
    }
}
