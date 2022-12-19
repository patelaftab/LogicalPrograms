using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogocalPrograms
{
    public class PerfectNumber
    {
        public static void checkingperfectnumber()
        {
            Console.WriteLine("Welcome To Perfect Number Program");
            Console.WriteLine("Enter a initial Number range to Check Whether Perfect Number or Not");
            int nx=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Ending Number Of range ");
            int ny=Convert.ToInt32(Console.ReadLine());
            int n, i, sum;
            for (n = nx; n <= ny; n++)
            {
                i = 1;
                sum= 0;
                while (i < n)
                {
                    if (n % i == 0)
                    
                        sum = sum + i;
                        i++;
                }
                if (sum == n)
                    Console.WriteLine("{0} " ,n);
            }
        }
    }
}
