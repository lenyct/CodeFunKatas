using CodeWars._5Kyu;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Test._5Kyu
{
    public class RGBToHexConversionTests
    {
        [Test]
        [Order(1)]
        public void FixedTests()
        {
            Assert.That(RGBToHexConversion.Rgb(255, 255, 255), Is.EqualTo("FFFFFF"));
            Assert.That(RGBToHexConversion.Rgb(255, 255, 300), Is.EqualTo("FFFFFF"));
            Assert.That(RGBToHexConversion.Rgb(0, 0, 0), Is.EqualTo("000000"));
            Assert.That(RGBToHexConversion.Rgb(148, 0, 211), Is.EqualTo("9400D3"));
            Assert.That(RGBToHexConversion.Rgb(148, -20, 211), Is.EqualTo("9400D3"), "Handle negative numbers.");
            Assert.That(RGBToHexConversion.Rgb(144, 195, 212), Is.EqualTo("90C3D4"));
            Assert.That(RGBToHexConversion.Rgb(212, 53, 12), Is.EqualTo("D4350C"), "Consider single hex digit numbers.");
        }
    }
}
