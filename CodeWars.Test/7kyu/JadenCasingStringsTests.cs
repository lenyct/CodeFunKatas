using CodeWars._7kyu;
using NUnit.Framework;

namespace CodeWars.Tests._7kyu
{
    public class JadenCasingStringsTests
    {
        [Test]
        public void FixedTest()
        {
            Assert.That("How can mirrors be real if our eyes aren't real".ToJadenCase(),
                        Is.EqualTo("How Can Mirrors Be Real If Our Eyes Aren't Real"),
                        "Strings didn't match.");
        }
    }
}
