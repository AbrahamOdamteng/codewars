﻿using System;
using System.Linq;

namespace CodeWars.kata._8kyu
{
    /// <summary>
    /// Create a method all which takes an array and a predicate (function pointer), 
    /// and returns true if the predicate returns true for every element in the array.
    /// Otherwise, it should return false. If the array is empty, it should return true,
    /// since technically nothing failed the test.
    /// </summary>
    class EnumerableMagic1TrueForAll
    {
        public static bool All(int[] arr, Func<int, bool> fun)
        {
            return arr.All(fun);
        }
    }
}
