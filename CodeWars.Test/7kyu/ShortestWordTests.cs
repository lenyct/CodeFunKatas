using CodeWars._7kyu;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Test._7kyu
{
    internal class ShortestWordTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.That(ShortestWord.FindShort("bitcoin take over the world maybe who knows perhaps"), Is.EqualTo(3));
            Assert.That(ShortestWord.FindShort("turns out random test cases are easier than writing out basic ones"), Is.EqualTo(3));
            Assert.That(ShortestWord.FindShort("Let's travel abroad shall we"), Is.EqualTo(2));
        }
    }
}
