using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Problems
{
     class PrimeNumber
    {
        public  void primeCheck()
        {

            int number= 0;
            Console.WriteLine("Enter a number to check prime Number");
            bool isPrime = true;
            

             for (int i = 2; i <= number/2; i++)
             {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
              }
            

            if (isPrime)
            {
                Console.WriteLine($"{number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number.");
            }
        }
    }


}
