using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CodeWars.kata._8kyu.EnumerableMagic;

namespace CodeWars.UnitTests._8kyu
{
    [TestFixture]
    class EnumerableMagic2TrueForAny_UnitTests
    {
        [Test]
        public void EnumerableMagic2TrueForAny_Test()
        {
            Assert.AreEqual(true, EnumerableMagic2TrueForAny.Any(new int[] { 1, 2, 3, 4 }, v => v > 3));
            Assert.AreEqual(false, EnumerableMagic2TrueForAny.Any(new int[] { 1, 2, 3, 4 }, v => v > 4));
        }
    }
}
