using LeetCode.Hard;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test.Hard
{
    class FirstMissingPositiveTest
    {
        [Test]
        public void ExampleTest1()
        {
            int[] nums = [1, 2, 0];
            var expected = 3;

            var result = FirstMissingPositive.FirstMissingPositiveMethod(nums);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ExampleTest2()
        {
            int[] nums = [3, 4, -1, 1];
            var expected = 2;

            var result = FirstMissingPositive.FirstMissingPositiveMethod(nums);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ExampleTest3()
        {
            int[] nums = [7, 8, 9, 11, 12];
            var expected = 1;

            var result = FirstMissingPositive.FirstMissingPositiveMethod(nums);
            Assert.That(result, Is.EqualTo(expected));
        }
        
        [Test]
        public void ExampleTest4()
        {
            int[] nums = [2147483647];
            var expected = 1;

            var result = FirstMissingPositive.FirstMissingPositiveMethod(nums);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ExampleTest5()
        {
            int[] nums = [1, 2, 3, 10, 2147483647, 9];
            var expected = 4;

            var result = FirstMissingPositive.FirstMissingPositiveMethod(nums);
            Assert.That(result, Is.EqualTo(expected));
        }

        
    }
}
