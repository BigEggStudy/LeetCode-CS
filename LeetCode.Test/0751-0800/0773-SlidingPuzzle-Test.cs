using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0773_SlidingPuzzle_Test
    {
        [TestMethod]
        public void SlidingPuzzle_1()
        {
            var solution = new _0773_SlidingPuzzle();
            var result = solution.SlidingPuzzle(new int[][] {
                new int[] { 1, 2, 3 },
                new int[] { 4, 0, 5 },
            });
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SlidingPuzzle_2()
        {
            var solution = new _0773_SlidingPuzzle();
            var result = solution.SlidingPuzzle(new int[][] {
                new int[] { 1, 2, 3 },
                new int[] { 5, 4, 0 },
            });
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void SlidingPuzzle_3()
        {
            var solution = new _0773_SlidingPuzzle();
            var result = solution.SlidingPuzzle(new int[][] {
                new int[] { 4, 1, 2 },
                new int[] { 5, 0, 3 },
            });
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void SlidingPuzzle_4()
        {
            var solution = new _0773_SlidingPuzzle();
            var result = solution.SlidingPuzzle(new int[][] {
                new int[] { 3, 2, 4 },
                new int[] { 1, 5, 0 },
            });
            Assert.AreEqual(14, result);
        }
    }
}
