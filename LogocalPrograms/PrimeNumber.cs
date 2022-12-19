using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogocalPrograms
{
    public class PrimeNumber
    {
        public static void checkingprimenumber()
        {
            Console.WriteLine("\nWelcome To Prime Number Program");
            Console.WriteLine("Enter a number to check Whether Prime or Not");
            int num=Convert.ToInt32(Console.ReadLine());
            int temp = 0;
            for(int i=1; i<=num; i++)
            {
                if(num%i==0) 
                {  
                    temp =temp+i;
                }
            }
            if (temp == num)
            {
                Console.WriteLine("Given Number is not a Prime Number");
            }
            else
            {
                Console.WriteLine("Given Number is a Prime Number");
            }
        }
    }
}
