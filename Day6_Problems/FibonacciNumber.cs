using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Problems
{
     class FibonacciNumber
    {
        public void Number()
        {
            int num, a = 0, b = 1, c = 0;


            Console.WriteLine("Enter limit");

            num = int.Parse(Console.ReadLine());

            for (int i = 0;i < num;i++)
            { 
                if (i == 1)
                {
                    Console.WriteLine(a);
                    continue;
                }
                if (i == 2)
                {
                    Console.WriteLine(b);
                    continue;
                }
                c = a + b;
                a = b;
                b = c;

                Console.WriteLine(c + " ");
            }

            Console.ReadLine();

        }



    }
}
