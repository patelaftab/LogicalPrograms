using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogocalPrograms
{
    public class ReverseNumber
    {
        public static void checkingreversenumber()
        {
            Console.WriteLine("Welcome To Reverse Number Program");
            Console.WriteLine("Enter a Number to be Reversed");
            int Num=Convert.ToInt32(Console.ReadLine());
            int reverse = 0;
            while(Num!=0)
            {
                int reminder = Num % 10;
                reverse = (reverse * 10) + reminder;
                Num=Num/10;
            }
            Console.WriteLine("Reversed Number is :" + reverse);
        }
    }
}
