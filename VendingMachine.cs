using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Progams_Day6
{
    /// <summary>
    /// This Program will give customer change to their money by giving Minimum number of notes available in the Vending Machine.
    /// </summary>
    public class VendingMachine
    {
        static int[] NotesAvailable = { 1, 2, 5, 10, 50, 100, 500, 1000 }; 
        public static void MinimumNumberofNotes()
        {
            int i = 0;
            int index = NotesAvailable.Length - 1;

            int numOfNotes = 0;
            int sum = 0;

            Console.Write("Enter the Money you Want: ");
            int Money=Convert.ToInt32(Console.ReadLine());
           
            
            while (sum != Money)
            {
                
                if(sum+NotesAvailable[index] <= Money)
                {
                    sum += NotesAvailable[index];
                    numOfNotes++;
                    i++;
                }
                else
                {
                    Console.WriteLine($"Note Given: {NotesAvailable[index]} x {i}");
                    i = 0;
                    index--;
                }
                
            }

            Console.WriteLine($"Minimum Number of notes Required for change of {Money} is {numOfNotes}");

        }
    }
}
