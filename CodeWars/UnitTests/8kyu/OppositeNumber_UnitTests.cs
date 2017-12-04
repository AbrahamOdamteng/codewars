using CodeWars.kata._8kyu;
using NUnit.Framework;

namespace CodeWars.UnitTests._8kyu
{
    [TestFixture]
    class OppositeNumber_UnitTests
    {
        [Test]
        public void OppositeNumber_Test()
        {
            Assert.AreEqual(-1, OppositeNumber.Opposite(1));
            Assert.AreEqual(-10, OppositeNumber.Opposite(10));
            Assert.AreEqual(-3, OppositeNumber.Opposite(3));
        }
    }
}
