namespace LeetCode.Easy
{
    public static class RemoveElementProblem
    {
        //Remove Element
        //https://leetcode.com/problems/remove-element/description/
        
        
        //Faster!
        //public static int RemoveElement(int[] nums, int val)
        //{
        //    int i = 0;
        //    int j = 0;
        //    while (i < nums.Length)
        //    {
        //        if (nums[i] != val)
        //        {
        //            nums[j] = nums[i];
        //            j++;
        //        }
        //        i++;
        //    }
        //    return j;
        //    //Look into linq.toarray.COPYTO
        //}

        public static int RemoveElement(int[] nums, int val)
        {
            var filtered = nums.Where(x => x != val).ToArray();
            var instances = filtered.Count();
            filtered.CopyTo(nums, 0);
            return instances;
        }
    }
}
