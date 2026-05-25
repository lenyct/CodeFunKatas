using CodeWars._6kyu;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Test._6kyu
{
    internal class CountTheSmileyFacesTests
    {
        [Test]
        [Order(1)]
        public void BasicTest()
        {
            Assert.That(CountTheSmileyFaces.CountSmileys(new string[] { ":D", ":~)", ";~D", ":)" }), Is.EqualTo(4));
            Assert.That(CountTheSmileyFaces.CountSmileys(new string[] { ":)", ":(", ":D", ":O", ":;" }), Is.EqualTo(2));
            Assert.That(CountTheSmileyFaces.CountSmileys(new string[] { ";]", ":[", ";*", ":$", ";-D" }), Is.EqualTo(1));
            Assert.That(CountTheSmileyFaces.CountSmileys(new string[] { ";", ")", ";*", ":$", "8-D" }), Is.EqualTo(0));
        }
    }
}
