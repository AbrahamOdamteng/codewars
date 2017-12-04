using CodeWars.kata._8kyu.EnumerableMagic;
using NUnit.Framework;
namespace CodeWars.UnitTests._8kyu.EnumerableMagic
{
    [TestFixture]
    class EnumerableMagic5TrueForJustOne_UnitTests
    {
        [Test]
        public void EnumerableMagic5TrueForJustOne_Test()
        {
            Assert.AreEqual(true, EnumerableMagic5TrueForJustOne.One(new int[] { 1, 2, 3, 4, 5 }, v => v < 2));
            Assert.AreEqual(false, EnumerableMagic5TrueForJustOne.One(new int[] { 1, 2, 3, 4, 5 }, v => v % 2 != 0));
            Assert.AreEqual(false, EnumerableMagic5TrueForJustOne.One(new int[] { 1, 2, 3, 4, 5 }, v => v > 5));
        }
    }
}
