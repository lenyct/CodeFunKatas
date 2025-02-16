using LeetCode.Easy;
using NUnit.Framework;

namespace LeetCode.Test.Easy
{
    class RemoveElementTest
    {
        [Test]
        public void Example1Test()
        {
            int[] nums = [3, 2, 2, 3];
            var val = 3;

           var result = RemoveElementProblem.RemoveElement(nums, val);
            Assert.That(result, Is.EqualTo(2));
            Assert.That(nums[0], Is.EqualTo(2));
            Assert.That(nums[1], Is.EqualTo(2));
        }

        [Test]
        public void Example2Test()
        {
            int[] nums = [0, 1, 2, 2, 3, 0, 4, 2];
            var val = 2;

            var result = RemoveElementProblem.RemoveElement(nums, val);
            Assert.That(result, Is.EqualTo(5));

            Assert.That(nums[0], Is.EqualTo(0));
            Assert.That(nums[1], Is.EqualTo(1));
            Assert.That(nums[2], Is.EqualTo(3));
            Assert.That(nums[3], Is.EqualTo(0));
            Assert.That(nums[4], Is.EqualTo(4));
        }
    }
}
