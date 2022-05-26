using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Progams_Day6
{
    /// <summary>
    /// This program will convert Temprature Unit from Celcius to Fahrenheit and Vice Versa.
    /// </summary>
    public class TempratureUnit
    {
        public static void ChangeUnit()
        {
            Console.Write("Enter \'1\' for Enter Temprature in Celcius OR  \'0\' for Enter Temprature in Fahrenheit: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Temprature: ");
            int Temprature = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    int Fahrenheit = (Temprature * 9 / 5) + 32;
                    Console.WriteLine($"{Temprature} celcius = {Fahrenheit} Fahrenheit");
                    break;
                case 0:
                    int Celcius = (Temprature - 32) * 5 / 9;
                    Console.WriteLine($"{Temprature} Fahrenheit = {Celcius} Celcius");
                    break;
            }

        }
    }
}
