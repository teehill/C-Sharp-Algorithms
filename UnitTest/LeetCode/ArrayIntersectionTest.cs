using Algorithms.LeetCode;
using System.Linq;
using Xunit;

namespace UnitTest.LeetCode
{
    public class ArrayIntersectionTest
    {
        [Fact]
        public void ArrayIntersection_MatchOne()
        {
            var expected = new int[] { 2, 3 };

            var result = ArrayIntersection.Intersection(new int[] {1, 2, 3}, new int[] {2, 3, 4});

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ArrayIntersection_MatchTwo()
        {
            var expected = new int[] { 4, 9 };
            
            var result = ArrayIntersection.Intersection(new int[] {4, 9, 5}, new int [] {9, 4, 9, 8, 4});

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ArrayIntersection_NoMatch()
        {
            var expected = new int[] { };

            var result = ArrayIntersection.Intersection(new int[] {1, 2, 3}, new int[] {4, 5, 6});

            Assert.Equal(expected, result);
        }
    }
}
