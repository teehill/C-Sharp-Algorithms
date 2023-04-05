using System.Collections.Generic;
using System.Linq;

namespace Algorithms.LeetCode
{
    public static class ArrayIntersection
    {
        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            var intersection = new List<int>();

            HashSet<int> larger, smaller;

            if (nums1.Count() > nums2.Count())
            {
                larger = new HashSet<int>(nums1);
                smaller = new HashSet<int>(nums2);
            }
            else
            {
                larger = new HashSet<int>(nums2);
                smaller = new HashSet<int>(nums1);
            }

            foreach (var smallValue in smaller)
            {
                if (larger.Contains(smallValue))
                {
                    intersection.Add(smallValue);
                }
            }

            return intersection.ToArray();
        }
    }
}