using CodeWars.kata._8kyu.EnumerableMagic;
using NUnit.Framework;

namespace CodeWars.UnitTests._8kyu
{
    [TestFixture]
    class EnumerableMagic1TrueForAll_UnitTests
    {
        public class KataTests
        {
            [Test]
            public void EnumerableMagic1TrueForAll_Test()
            {
                Assert.AreEqual(true, EnumerableMagic1TrueForAll.All(new int[] { 1, 2, 3, 4, 5 }, v => v < 9));
                Assert.AreEqual(false, EnumerableMagic1TrueForAll.All(new int[] { 1, 2, 3, 4, 5 }, v => v > 9));
            }
        }
    }
}
