using CodeWars.kata._8kyu;
using NUnit.Framework;
namespace CodeWars.UnitTests._8kyu
{
    [TestFixture]
    class SumOfPositive_UnitTests
    {
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, ExpectedResult = 15)]
        [TestCase(new int[] { 1, -2, 3, 4, 5 }, ExpectedResult = 13)]
        [TestCase(new int[] { -1, 2, 3, 4, -5 }, ExpectedResult = 9)]
        [TestCase(new int[] { }, ExpectedResult = 0)]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, ExpectedResult = 0)]
        public static int SumOfPositive_Test(int[] arr)
        {
            return SumOfPositive.PositiveSum(arr);
        }
    }
}
