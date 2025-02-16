namespace LeetCode.Easy
{
    //https://leetcode.com/problems/remove-duplicates-from-sorted-array/?envType=study-plan-v2&envId=top-interview-150

    //Hint, They are checking the value of the array afterwards 
    //so change in place
    public static class RemoveDuplicatesSortedArray
    {
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;

            var index = 1;
            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[index++] = nums[i];
                }
            }
            return index;
        }
    }
}
