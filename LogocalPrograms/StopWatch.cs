using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogocalPrograms
{
    public class StopWatch
    {
        public static void stopwatch()
        {
            Stopwatch watchObject = new Stopwatch();
            Console.WriteLine("Press Any key to start the Timer : ");
            String startTimer = Console.ReadLine(); //taking input from user to start the timer .
            while (startTimer != null)
            {
                watchObject.Start();        //starting the timer counting's
                Console.WriteLine("Enter Any key to stop the Timer :");
                Console.ReadLine();     //taking input from user to stop the timer .
                watchObject.Stop();     //stopping the timer .
                break;
            }
            Console.WriteLine($"Time elapsed : {watchObject.Elapsed}");
        }
    }
}
