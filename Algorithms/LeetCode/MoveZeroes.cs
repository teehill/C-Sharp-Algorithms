using System.Collections.Generic;

namespace Algorithms.LeetCode
{
    public static class MoveZeroes
    {
        public static int[] MoveZeroesToEnd(int[] nums)
        {
            var zeroIndex = -1;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    if (zeroIndex > -1)
                    {
                        (nums[i], nums[zeroIndex]) = (nums[zeroIndex], nums[i]);
                        zeroIndex++;
                    }
                }
                else
                {
                    if (zeroIndex == -1)
                        zeroIndex = i;
                }
            }

            return nums;
        }
    }
}