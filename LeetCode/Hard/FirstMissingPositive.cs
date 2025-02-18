using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hard
{
    public class FirstMissingPositive
    {
        //https://leetcode.com/problems/first-missing-positive/
        public static int FirstMissingPositiveMethod(int[] nums)
        {
            var positives = nums.OrderBy(x => x).Where((x) => x > 0);
            if (!positives.Any() || positives.First() != 1) return 1;
            var range = Enumerable.Range(1, positives.Last() + 1);

            return range.Except(positives).First();
          //  return range.Where(x => !positives.Contains(x)).First();
        }
    }
}
