using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Progams_Day6
{
    public class Simulate_StopWatch
    {
        static Stopwatch watch = new Stopwatch();
        public static void Start()
        {

            StartStopWatch();
            EndStopWatch();

            Console.WriteLine($"Times Elapsed: {watch.Elapsed}");
        }

        public static void StartStopWatch()
        {
            string input = "null";
            while(input != "1")
            {
                Console.Write("Enter the \'1\' to start the stop Watch: ");
                input = Console.ReadLine();
                if(input == "1")
                    watch.Start();
            }

        }

        public static void EndStopWatch()
        {
            string input = "null";
            while(input != "0")
            {
                Console.Write("Enter the \'0\' to Stop the Stop Watch: ");
                input = Console.ReadLine();
                if (input == "0")
                    watch.Stop();
            }
            
        }
    }
}
