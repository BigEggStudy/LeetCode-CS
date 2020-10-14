using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0452_MinimumNumberOfArrowsToBurstBalloons_Test
    {
        [TestMethod]
        public void FindMinArrowShots_1()
        {
            var solution = new _0452_MinimumNumberOfArrowsToBurstBalloons();
            var result = solution.FindMinArrowShots(new int[][] {
                new int[] { 10, 16 },
                new int[] { 2, 8 },
                new int[] { 1, 6 },
                new int[] { 7, 12 },
            });
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void FindMinArrowShots_2()
        {
            var solution = new _0452_MinimumNumberOfArrowsToBurstBalloons();
            var result = solution.FindMinArrowShots(new int[][] {
                new int[] { 1, 2 },
                new int[] { 3, 4 },
                new int[] { 5, 6 },
                new int[] { 7, 8 },
            });
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void FindMinArrowShots_3()
        {
            var solution = new _0452_MinimumNumberOfArrowsToBurstBalloons();
            var result = solution.FindMinArrowShots(new int[][] {
                new int[] { 1, 2 },
                new int[] { 2, 3 },
                new int[] { 3, 4 },
                new int[] { 4, 5 },
            });
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void FindMinArrowShots_4()
        {
            var solution = new _0452_MinimumNumberOfArrowsToBurstBalloons();
            var result = solution.FindMinArrowShots(new int[][] {
                new int[] { 1, 2 },
            });
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void FindMinArrowShots_5()
        {
            var solution = new _0452_MinimumNumberOfArrowsToBurstBalloons();
            var result = solution.FindMinArrowShots(new int[][] {
                new int[] { 2, 3 },
                new int[] { 2, 3 },
            });
            Assert.AreEqual(1, result);
        }
    }
}
