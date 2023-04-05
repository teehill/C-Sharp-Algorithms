using System.Collections.Generic;

namespace Algorithms.LeetCode
{
    public static class MoveZeroes
    {
        public static int[] MoveZeroesToEnd(int[] nums)
        {
            var nonZeroIndex = 0;

            //move all non-zeroes to front of array, tracked with nonZeroIndex
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[nonZeroIndex] = nums[i];
                    nonZeroIndex++;
                }
            }

            //replace non-zero duplicates starting from nonZeroIndex
            for (var i = nonZeroIndex; i < nums.Length; i++)
            {   
                nums[i] = 0;
            }

            return nums;
        }
    }
}