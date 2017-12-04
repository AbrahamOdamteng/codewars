using CodeWars.kata._8kyu;
using NUnit.Framework;
namespace CodeWars.UnitTests._8kyu
{
    [TestFixture]
    class EvenOrOdd_UnitTests
    {
        [Test]
        public void EvenOrOdd_Test()
        {
            Assert.AreEqual("Even", EvenOrOddKata.EvenOrOdd(2));
            Assert.AreEqual("Odd", EvenOrOddKata.EvenOrOdd(1));
            Assert.AreEqual("Even", EvenOrOddKata.EvenOrOdd(0));
            Assert.AreEqual("Odd", EvenOrOddKata.EvenOrOdd(7));
        }
    }
}
