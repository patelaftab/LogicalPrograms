using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogocalPrograms
{
     public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Logical Programs : Please Choose a Option\n" +
                "Press 1: Fibonacci Series Program\n" +
                "Press 2: Perfect Number Program");
            int options=Convert.ToInt32(Console.ReadLine());
            switch(options) 
            {
                case 1:
                    FibonacciSeries.checknumber();
                    break;
                case 2:
                    PerfectNumber.checkingperfectnumber();
                    break;
                default:
                    Console.WriteLine("Please Chose a Valid Option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
