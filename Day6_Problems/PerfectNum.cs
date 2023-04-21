using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Problems
{
     class PerfectNum
    {
        public void perfectNum() 
        {
            Console.WriteLine("'Enter Number to check");
            int num =Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (int i = 0;i< num; i++)
            {
                if (num%i == 0)
                {
                    sum += i;
                }
            }
            if (sum == num)
            {
                Console.WriteLine("Given Number is perfect");
            }
            else
            {
                Console.WriteLine("Given number is not Perfect");
            }
        }
    }
}
