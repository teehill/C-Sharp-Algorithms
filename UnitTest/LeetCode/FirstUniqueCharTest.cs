using Algorithms.LeetCode;
using System.Linq;
using Xunit;

namespace UnitTest.LeetCode
{
    public class FirstUniqueCharTest
    {
        [Fact]
        public void FirstUniqueChar_FirstIndex_isZero()
        {
            var result = FirstUniqueChar.FirstUniqChar("leetcode");

            Assert.Equal(0, result);    
        }

        [Fact]
        public void FirstUniqueChar_MiddleIndex_()
        {
            var result = FirstUniqueChar.FirstUniqChar("loveleetcode");

            Assert.Equal(2, result);    
        }

        [Fact]
        public void FirstUniqueChar_NoUniqueChars()
        {
            var result = FirstUniqueChar.FirstUniqChar("aabb");

            Assert.Equal(-1, result);    
        }
        
    }
}
