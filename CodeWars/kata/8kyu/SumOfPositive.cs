using System.Linq;

namespace CodeWars.kata._8kyu
{
    /// <summary>
    /// You get an array of numbers, return the sum of all of the positives ones.
    /// </summary>
    class SumOfPositive
    {
        public static int PositiveSum(int[] arr)
        {
            return arr.Where(x => x >= 0).Sum();
        }
    }
}
