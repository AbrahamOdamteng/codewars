using CodeWars.kata._8kyu;
using NUnit.Framework;
using System;

namespace CodeWars.UnitTests._8kyu
{
    [TestFixture]
    public class ConvertBooleanValuesToStringsYesOrNo_UnitTests
    {

        [Test]
        public void ConvertBooleanValuesToStringsYesOrNo_Returned1()
        {
            Assert.AreEqual("Yes", ConvertBooleanValuesToStringsYesOrNo.boolToWord(true));
            Console.WriteLine("Expected Yes");
        }

        [Test]
        public void ConvertBooleanValuesToStringsYesOrNo_Returned2()
        {
            Assert.AreEqual("No", ConvertBooleanValuesToStringsYesOrNo.boolToWord(false));
            Console.WriteLine("Expected No");
        }

        [Test]
        public void ConvertBooleanValuesToStringsYesOrNo_Returned3()
        {
            Assert.AreEqual("Yes", ConvertBooleanValuesToStringsYesOrNo.boolToWord(true));
            Console.WriteLine("Expected Yes");
        }
    }
}
