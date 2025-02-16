using CodeWars._7kyu;
using NUnit.Framework;

namespace CodeWars.Tests._7kyu
{
    public class MaskifyTests
    {
        [Test]
        [Order(1)]
        public void ExamplesTests()
        {
            Assert.That(MaskifyCode.Maskify("4556364607935616"), Is.EqualTo("############5616"));
            Assert.That(MaskifyCode.Maskify("1"), Is.EqualTo("1"));
            Assert.That(MaskifyCode.Maskify("11111"), Is.EqualTo("#1111"));
        }
    }
}
