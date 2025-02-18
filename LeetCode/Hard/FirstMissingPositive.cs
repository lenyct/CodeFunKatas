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
        //370ms        Beats 9.28% of all
        public static int FirstMissingPositiveMethod(int[] nums)
        {
            var positives = nums.OrderBy(x => x).Where((x) => x > 0);
            if (!positives.Any()) return 1;
            var range = Enumerable.Range(1, positives.Last());

            return range.Except(positives).FirstOrDefault(range.Last()+1);
        }
    }
}
