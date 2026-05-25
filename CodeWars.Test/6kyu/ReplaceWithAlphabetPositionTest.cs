using CodeWars._6kyu;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Test._6kyu
{
    internal class ReplaceWithAlphabetPositionTest
    {
        [Test, Order(1)]
        public void SampleTest()
        {
            Assert.That(ReplaceWithAlphabetPosition.AlphabetPosition("The sunset sets at twelve o' clock."), Is.EqualTo("20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11"));
            Assert.That(ReplaceWithAlphabetPosition.AlphabetPosition("The narwhal bacons at midnight."), Is.EqualTo("20 8 5 14 1 18 23 8 1 12 2 1 3 15 14 19 1 20 13 9 4 14 9 7 8 20"));
        }
    }
}
