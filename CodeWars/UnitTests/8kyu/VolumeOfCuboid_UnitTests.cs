using CodeWars.kata._8kyu;
using NUnit.Framework;

namespace CodeWars.UnitTests._8kyu
{
    [TestFixture]
    class VolumeOfCuboid_UnitTests
    {
        [Test]
        public void VolumeOfCuboid_Tests()
        {
            Assert.AreEqual(4, VolumeOfCuboid.getVolumeOfCubiod(1, 2, 2));
            Assert.AreEqual(63, VolumeOfCuboid.getVolumeOfCubiod(6.3, 2, 5));
        }
    }
}
