using CodeWars._8Kyu;
using NUnit.Framework;

namespace CodeWars.Test._8Kyu
{
    public class ReversedStringsTest
    {
        [Test]
        public void World()
        {
            Assert.That(ReversedStrings.Solution("world"), Is.EqualTo("dlrow"));
        }
    }
}
