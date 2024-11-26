using Algorithms.LeetCode;
using System.Linq;
using Xunit;

namespace UnitTest.LeetCode
{
    public class MoveZeroesTest
    {
        [Fact]
        public void MoveZeroes_SingleZero_MovesToEnd()
        {
            var expected = new int[] { 1, 2, 3, 0 };

            var result = MoveZeroes.MoveZeroesToEnd(new int[] { 1, 0, 2, 3 });

            Assert.Equal(expected, result);
        }

        [Fact]
        public void MoveZeroes_TailingZero_NothingMoves()
        {
            var expected = new int[] { 4, 9, 5, 0 };

            var result = MoveZeroes.MoveZeroesToEnd(new int[] { 4, 9, 5, 0 });

            Assert.Equal(expected, result);
        }

        [Fact]
        public void MoveZeroes_NoZeroes_NothingMoves()
        {
            var expected = new int[] { 1, 2, 3 };

            var result = MoveZeroes.MoveZeroesToEnd(new int[] { 1, 2, 3 });

            Assert.Equal(expected, result);
        }

        [Fact]
        public void MoveZeroes_TwoZeroes_MovesToBack()
        {
            var expected = new int[] { 1, 2, 3, 5, 7, 9, 0, 0 };

            var result = MoveZeroes.MoveZeroesToEnd(new int[] { 1, 0, 2, 3, 5, 0, 7, 9 });

            Assert.Equal(expected, result);
        }

        [Fact]
        public void MoveZeroes_ManyZeroes_MovesToBack()
        {
            var expected = new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0 };

            var result = MoveZeroes.MoveZeroesToEnd(new int[] { 0, 0, 0, 0, 1, 0, 0, 0, 0 });

            Assert.Equal(expected, result);
        }

        [Fact]
        public void MoveZeroes_Empty_DoesNothing()
        {
            var expected = new int[] { };

            var result = MoveZeroes.MoveZeroesToEnd(new int[] { });

            Assert.Equal(expected, result);
        }

        [Fact]
        public void MoveZeroes_AllZeroes_DoesNothing()
        {
            var expected = new int[] { 0, 0, 0, 0, 0, };

            var result = MoveZeroes.MoveZeroesToEnd(new int[] { 0, 0, 0, 0, 0, });

            Assert.Equal(expected, result);
        }
    }
}
