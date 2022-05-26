using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Progams_Day6
{
    public class DecimalTOBinary
    {
        public static void GetDecimal()
        {
            Console.Write("Enter the Decimal number to convert it into 2 base Binary Formate: ");
            int Decimal = Convert.ToInt32(Console.ReadLine());
            int[] Binary=getBinary(Decimal);
            PrintArray(Binary);  
        }

        public static int[] getBinary(int Decimal)
        {
            int i;
            int[] a = new int[8];
            
            for (i = 0; Decimal > 0; i++)
            {
                a[i] = Decimal % 2;
                Decimal = Decimal / 2;
            }
            Array.Reverse(a);
            return a;
        }

        public static void PrintArray(int[] myArray)
        {
            for (int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++)
                Console.Write(myArray[i]);
            Console.WriteLine();
        }
    }
}
