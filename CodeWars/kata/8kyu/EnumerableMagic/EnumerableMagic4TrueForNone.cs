using System;
using System.Linq;
namespace CodeWars.kata._8kyu.EnumerableMagic
{
    /// <summary>
    /// Create a method none? (JS none) that accepts an array and a block (JS: a function), 
    /// and returns true if the block (/function) returns true for none of the items in the array. 
    /// An empty list should return true.
    /// </summary>
    class EnumerableMagic4TrueForNone
    {
        public static bool None(int[] arr, Func<int, bool> fun)
        {
            return !arr.Any(fun);
        }
    }
}
