using CodeWars.kata._8kyu;
using NUnit.Framework;

namespace CodeWars.UnitTests._8kyu
{
    [TestFixture]
    class SpeedCode2ArrayMadness_UnitTests
    {
        [Test, Description("Should work for sample tests")]
        public void SpeedCode2ArrayMadness_Test()
        {
            Assert.AreEqual(true, SpeedCode2ArrayMadness.ArrayMadness(new int[] { 4, 5, 6 }, new int[] { 1, 2, 3 }));
            Assert.AreEqual(false, SpeedCode2ArrayMadness.ArrayMadness(new int[] { 5, 6, 7 }, new int[] { 4, 5, 6 }));
        }
    }
}

