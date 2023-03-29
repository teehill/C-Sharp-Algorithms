using System.Collections.Generic;
using System.Linq;

namespace Algorithms.LeetCode
{
    public static class ArrayIntersection
    {
        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            var intersection = new List<int>();
            var nums1set = new HashSet<int>(nums1);
            var nums2set = new HashSet<int>(nums2);

            HashSet<int> larger, smaller;

            if (nums1set.Count() > nums1set.Count())
            {
                larger = nums1set;
                smaller = nums2set;
            }
            else
            {
                larger = nums2set;
                smaller = nums1set;
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