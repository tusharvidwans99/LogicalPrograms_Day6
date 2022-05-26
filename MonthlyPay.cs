using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Progams_Day6
{
    public class MonthlyPay
    {
        public static void calculateMonthlyPayment()
        {
            Console.Write("Enter the Principal Amount: ");
            double Principal = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter in How many Years you have to Pay Principal Amount: ");
            double year=Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Rate of Interest Compounded Monthly: ");
            double ROI = Convert.ToDouble(Console.ReadLine());
            getMonthlyRate(Principal, year, ROI);
        }


        public static void getMonthlyRate(double Principal,double year, double ROI)
        {
            double n = 12 * year;
            double r = ROI / (12 * 100);
            double Monthly_Rate = Math.Round((Principal * r) / (1 - Math.Pow(1 + r, -n)),2);
            Console.WriteLine($"So you have to pay: {Monthly_Rate} Monthly");
        }
    }
}
