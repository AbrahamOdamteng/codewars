using System.Linq;

namespace CodeWars.kata._8kyu
{
    /// <summary>
    /// Define to_alternating_case(char*) such that each lowercase letter becomes
    /// uppercase and each uppercase letter becomes lowercase.
    /// </summary>
    static class AlternatingCase
    {
        public static string ToAlternatingCase(this string s)
        {
            return string.Concat(s.Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)));
        }
    }
}
