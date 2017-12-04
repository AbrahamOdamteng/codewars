using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars._8kyu
{
    class RemoveFirstAndLastCharacter
    {
        public static string Remove_char(string s)
        {
            return new string(s.ToCharArray(1, s.Length - 2));
        }
    }
}
