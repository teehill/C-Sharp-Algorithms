using System.Collections.Generic;

namespace Algorithms.LeetCode
{
    public static class MoveZeroes
    {
        public static int[] MoveZeroesToEnd(int[] nums)
        {

            var zeroIndex = nums.Length - 1;

            //starting at end, look for last zero, swap it back to zeroIndex, pull up, decremenent zeroIndex
            for (var i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] == 0)
                {
                    for (var j = i; j < zeroIndex; j++)
                    {
                        //the ol tupel swapperoo
                        (nums[j], nums[j + 1]) = (nums[j + 1], nums[j]);
                    }

                    zeroIndex--;
                }
            }

            return nums;
        }
    }
}