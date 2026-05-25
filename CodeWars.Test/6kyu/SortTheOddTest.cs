using CodeWars._6kyu;
using NUnit.Framework;

namespace CodeWars.Tests._6kyu
{
    public class SortTheOddTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.That(SortTheOdd.SortArray(new int[] { 5, 3, 2, 8, 1, 4 }), Is.EqualTo(new int[] { 1, 3, 2, 8, 5, 4 }));
            Assert.That(SortTheOdd.SortArray(new int[] { 5, 3, 1, 8, 0 }), Is.EqualTo(new int[] { 1, 3, 5, 8, 0 }));
            Assert.That(SortTheOdd.SortArray(new int[] { }), Is.EqualTo(new int[] { }));
        }
    }
}
