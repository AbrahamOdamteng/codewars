using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.kata._8kyu.EnumerableMagic
{
    /// <summary>
    /// Create an any? (JS: any) function that accepts an array and a block (JS: function),
    /// and returns true if the block (/function) returns true for any item in the array.
    /// If the array is empty, the function should return false.
    /// </summary>
    class EnumerableMagic2TrueForAny
    {
        public static bool Any(int[] arr, Func<int, bool> fun)
        {
            return arr.Any(fun);
        }
    }
}
