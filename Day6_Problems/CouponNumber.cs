using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Logical_Problems
{
    internal class Coupon_Number
    {
        public void CouponNum()
        {
            Console.WriteLine("Enter the number of distinct coupon numbers want to generate");
            int number = int.Parse(Console.ReadLine());
            char[] chars = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            string[] digit = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            Random random = new Random();
            Console.WriteLine("Coupon Numbers are:");
            for (int i = 0; i < number; i++)
            {
                string Chars = "";
                string Digits = "";
                for (int j = 0; j < 3; j++)
                {
                    int char_index = random.Next(chars.Length);
                    int digit_index = random.Next(digit.Length);
                    Chars += chars[char_index];
                    Digits += digit[digit_index];

                }
                Console.WriteLine(Chars + Digits);
            }
        }
    }
}
