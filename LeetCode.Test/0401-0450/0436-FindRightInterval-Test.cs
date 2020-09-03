using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0436_FindRightInterval_Test
    {
        [TestMethod]
        public void FindRightInterval_1()
        {
            var solution = new _0436_FindRightInterval();
            var result = solution.FindRightInterval(new int[][] {
                new int[] { 1, 2 },
            });
            AssertHelper.AssertArray(new int[] { -1 }, result);
        }

        [TestMethod]
        public void FindRightInterval_2()
        {
            var solution = new _0436_FindRightInterval();
            var result = solution.FindRightInterval(new int[][] {
                new int[] { 3, 4 },
                new int[] { 2, 3 },
                new int[] { 1, 2 },
            });
            AssertHelper.AssertArray(new int[] { -1, 0, 1 }, result);
        }

        [TestMethod]
        public void FindRightInterval_3()
        {
            var solution = new _0436_FindRightInterval();
            var result = solution.FindRightInterval(new int[][] {
                new int[] { 1, 4 },
                new int[] { 2, 3 },
                new int[] { 3, 4 },
            });
            AssertHelper.AssertArray(new int[] { -1, 2, -1 }, result);
        }
    }
}
