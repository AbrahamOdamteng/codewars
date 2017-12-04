﻿using CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.UnitTests._8kyu
{

    [TestFixture]
    class RemoveFirstAndLastCharacterUnitTests
    {

        [Test]
        public void RemoveFirstAndLastCharacter_Test1()
        {
            StringAssert.AreEqualIgnoringCase("loquen", RemoveFirstAndLastCharacter.Remove_char("eloquent"));
            StringAssert.AreEqualIgnoringCase("ountr", RemoveFirstAndLastCharacter.Remove_char("country"));
            StringAssert.AreEqualIgnoringCase("erso", RemoveFirstAndLastCharacter.Remove_char("person"));
            StringAssert.AreEqualIgnoringCase("lac", RemoveFirstAndLastCharacter.Remove_char("place"));
            StringAssert.AreEqualIgnoringCase("", RemoveFirstAndLastCharacter.Remove_char("ok"));
        }

    }
}
