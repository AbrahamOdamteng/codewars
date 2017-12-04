using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.kata._8kyu.EnumerableMagic
{
    /// <summary>
    /// Create a method one? (JS one) that accepts two params, a list and a block (JS: a function), 
    /// and returns true only if the block (/function) returns true for exactly one item in the array
    /// </summary>
    class EnumerableMagic5TrueForJustOne
    {
        public static bool One(int[] arr, Func<int, bool> fun)
        {
            return arr.Count(x => fun(x) == true) == 1;
        }
    }
}
