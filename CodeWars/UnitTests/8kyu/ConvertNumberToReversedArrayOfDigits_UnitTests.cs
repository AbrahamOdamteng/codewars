using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CodeWars.kata._8kyu;

namespace CodeWars.UnitTests._8kyu
{
    [TestFixture]
    class ConvertNumberToReversedArrayOfDigits_UnitTests
    {
        [Test]
        public void ConvertNumberToReversedArrayOfDigits_Test()
        {
            Assert.AreEqual(new long[] { 1, 3, 2, 5, 3 }, ConvertNumberToReversedArrayOfDigits.Digitize(35231));
        }
    }
}
