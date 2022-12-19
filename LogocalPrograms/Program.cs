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
                "Press 1: Fibonacci Series");
            int options=Convert.ToInt32(Console.ReadLine());
            switch(options) 
            {
                case 1:
                    FibonacciSeries.checknumber();
                    break;
            }
            Console.ReadLine();
        }
    }
}
