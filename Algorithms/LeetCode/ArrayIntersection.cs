using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Numeric
{
    public static class Solution
    {
        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            var intersection = new List<int>();
            var larger = new HashSet<int>();
            var smaller = new HashSet<int>();

            larger = nums1.Length > nums2.Length ? nums1.ToHashSet<int>() : nums2.ToHashSet<int>();
            smaller = nums1.Length < nums2.Length ? nums1.ToHashSet<int>() : nums2.ToHashSet<int>();

            foreach (var smol in smaller)
            {
                if (larger.Contains(smol))
                {
                    intersection.Add(smol);
                }
            }

            return intersection.ToArray();
        }
    }
}