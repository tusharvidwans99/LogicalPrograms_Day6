using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Progams_Day6
{
    public class Decimal_Binary_Swap
    {

        public static void CompareBinaryDecimal()
        {
            Console.Write("Enter the Decimal number to convert it into 2 base Binary Formate: ");
            int Decimal = Convert.ToInt32(Console.ReadLine());
            
            int[] Binary = DecimalTOBinary.getBinary(Decimal);
            Console.Write($"Binary number for {Decimal} is: ");
            DecimalTOBinary.PrintArray(Binary);

            int[] SwapBinary=SwapNibbles(Binary);
            Console.Write($"Swapping the Nibbles: ");
            DecimalTOBinary.PrintArray(SwapBinary);
            
            int SwapedDecimal = getDecimal(SwapBinary);
            Console.Write($"Decimal number for Swapped Nibbles are: ");
            Console.WriteLine(SwapedDecimal);

            if (isPowerOf2(SwapedDecimal))
                Console.WriteLine("It's Power of 2");
            else
                Console.WriteLine("Not Power of 2");

        }




        public static int getDecimal(int[] SwapedBinary)
        {
            int decVal = 0, baseVal = 1, lastdigit;
            for (int i = SwapedBinary.Length - 1; i >= 0; i--)
            {
                lastdigit = SwapedBinary[i];
                decVal = decVal + lastdigit * baseVal;
                baseVal = baseVal * 2;
            }
            return decVal;
        }

        public static int[] SwapNibbles(int[] arr)
        {
            int temp, j = arr.Length - 4;
            for (int i = 0; i <4; i++)
            { // loop runs 4 times and swap first four element to last four elements
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                j++;
            }
            return arr;
        }

        public static bool isPowerOf2(int SwapedDecimal)
        {
            int i = 0, temp=1;
            
            while (temp < SwapedDecimal)
            {
                temp = (int)Math.Pow(2, i);
                              
                if (temp == SwapedDecimal)
                {
                    return true;
                }
                i++;
            }
            return false;
        }
    }
}
