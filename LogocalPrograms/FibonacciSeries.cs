﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogocalPrograms
{
    public class FibonacciSeries
    {
        public static void checknumber()
        {
            Console.WriteLine("Welcome To Fibonacci Series Program");
            int n1 = 0, n2 = 1, n3, num;
            Console.WriteLine("Enter Number to check Fibonacci series");
            num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n1 + " \n" +
                n2 + "");
            for(int i=2; i<num; i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3+ " " );
                n1 = n2;
                n2= n3;
            }

        }
    }
}
