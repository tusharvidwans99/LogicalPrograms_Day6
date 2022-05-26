using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Progams_Day6
{
    /// <summary>
    /// This program will give the day of the week from Date, Month & Year which gets from the user.
    /// </summary>
    public class DayOfWeek
    {

        public static void getinput()
        {
            int month, year, date;
            Console.Write("Enter the Year: ");
            year = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.Write("Enter the Month in Number from 1-12: ");
                month = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the date of the Month: ");
                date = Convert.ToInt32(Console.ReadLine());

            } while ((month < 0 || month > 12) || (date < 0 || date > 31));


            string dayofweek = getDay(year, month, date);
            Console.Write(dayofweek);


        }

        public static string getDay(int y,int m, int d)
        {

            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31*m0 / 12) % 7;

            switch (d0)
            {
                case 0:
                    return "Sunday";
                case 1:
                    return "Monday";
                case 2:
                    return "Tuesday";
                case 3:
                    return "Wednesday";
                case 4:
                    return "Thursday";
                case 5:
                    return "Friday";
                case 6:
                    return "Saturday";
                default:
                    return "1";
            }
                
        }


    }
}
