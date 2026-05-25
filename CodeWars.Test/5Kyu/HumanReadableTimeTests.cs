using CodeWars._5Kyu;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Test._5Kyu
{
    internal class HumanReadableTimeTests
    {
        private void DoTest(int seconds, String expected)
        {
            string actual = HumanReadableTime.GetReadableTime(seconds);
            Assert.That(actual, Is.EqualTo(expected), "for " + seconds + " seconds");
        }

        [Test]
        public void SampleTests()
        {
            //DoTest(0, "00:00:00");
            //DoTest(59, "00:00:59");
            //DoTest(60, "00:01:00");
            //DoTest(90, "00:01:30");
            DoTest(3599, "00:59:59");
            DoTest(3600, "01:00:00");
            DoTest(45296, "12:34:56");
            DoTest(86399, "23:59:59");
            DoTest(86400, "24:00:00");
            DoTest(359999, "99:59:59");
        }
    }
}
