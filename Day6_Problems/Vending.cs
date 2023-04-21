using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Problems
{
    internal class Vending_Machine
    {
        public static void GetMinimumNumOfNotes(int amount)
        {
            int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int[] numOfNotes = new int[notes.Length];
            int i = 0;
            while (amount > 0)
            {
                if (amount >= notes[i])
                {
                    int remainder = amount % notes[i];
                    numOfNotes[i] = amount / notes[i];
                    amount = remainder;
                }
                i++;
            }
            for ( int j =0; j < numOfNotes.Length; j++ )
            {
                if (numOfNotes[j] != 0)
                    Console.WriteLine("Number of " + notes[j] + "rs notes: " + numOfNotes[j]);
            }
        }
    }
}
