using System;
using System.Linq;

namespace CodeWars.kata._8kyu
{
    /// <summary>
    /// Given a random number: You have to return 
    /// the digits of this number within an array in reverse order.
    /// </summary>
    class ConvertNumberToReversedArrayOfDigits
    {
        public static long[] Digitize(long n)
        {
            return n.ToString().Reverse().Select(x => Convert.ToInt64(x.ToString())).ToArray();
        }
    }
}
