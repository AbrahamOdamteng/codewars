using CodeWars.kata._8kyu.EnumerableMagic;
using NUnit.Framework;

namespace CodeWars.UnitTests._8kyu
{
    [TestFixture]
    public class EnumerableMagic4TrueForNone_UnitTests
    {
        [Test]
        public void EnumerableMagic4TrueForNone_Tests()
        {
            Assert.AreEqual(true, EnumerableMagic4TrueForNone.None(new int[] { 1, 2, 3, 4, 5 }, v => v > 5));
            Assert.AreEqual(false, EnumerableMagic4TrueForNone.None(new int[] { 1, 2, 3, 4, 5 }, v => v > 4));
        }
    }
}
