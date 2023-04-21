using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Problems
{
     class Reverse
    {
        public void reverseNum()
        {
            Console.WriteLine("Enter Number To Reverse");

           int num = Convert.ToInt32(Console.ReadLine());

            int rev = 0;
            while (num > 0)
            {
                int reminder = num % 10;
                rev = (rev * 10) + reminder;
                num /= 10;
            }
            Console.WriteLine("Reversed number:" + num);
        }
    }
}
