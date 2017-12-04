using System.Linq;

namespace CodeWars.kata._8kyu
{
    /// <summary>
    /// Given two integer arrays a, b, both of length >= 1, 
    /// create a program that returns true if the sum of the squares of 
    /// each element in a is strictly greater than the sum of the cubes 
    /// of each element in b.
    /// </summary>
    class SpeedCode2ArrayMadness
    {
        public static bool ArrayMadness(int[] a, int[] b)
        {
            return a.Sum(x => x * x) > b.Sum(x => x * x * x);
        }
    }
}
