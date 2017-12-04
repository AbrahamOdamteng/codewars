using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.kata._8kyu.EnumerableMagic
{
    class EnumerableMagic2TrueForAny
    {
        public static bool Any(int[] arr, Func<int, bool> fun)
        {
            return arr.Any(fun);
        }
    }
}
