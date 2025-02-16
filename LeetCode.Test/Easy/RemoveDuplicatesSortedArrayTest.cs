using LeetCode.Easy;
using NUnit.Framework;

namespace LeetCode.Test.Easy
{
    class RemoveDuplicatesSortedArrayTest
    {
        [Test]
        public void SampleTest1()
        {
            int[] nums = [1, 1, 2];
            var result = RemoveDuplicatesSortedArray.RemoveDuplicates(nums);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void SampleTest2()
        {
            int[] nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
            var result = RemoveDuplicatesSortedArray.RemoveDuplicates(nums);

            Assert.That(result, Is.EqualTo(5));
        }
    }
}
