using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0997_FindTheTownJudge_Test
    {
        [TestMethod]
        public void FindJudge_1()
        {
            var solution = new _0997_FindTheTownJudge();
            var result = solution.FindJudge(2, new int[][] {
                new int[] { 1, 2 },
            });
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void FindJudge_2()
        {
            var solution = new _0997_FindTheTownJudge();
            var result = solution.FindJudge(3, new int[][] {
                new int[] { 1, 3 },
                new int[] { 2, 3 },
            });
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void FindJudge_3()
        {
            var solution = new _0997_FindTheTownJudge();
            var result = solution.FindJudge(3, new int[][] {
                new int[] { 1, 3 },
                new int[] { 2, 3 },
                new int[] { 3, 1 },
            });
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void FindJudge_4()
        {
            var solution = new _0997_FindTheTownJudge();
            var result = solution.FindJudge(3, new int[][] {
                new int[] { 1, 2 },
                new int[] { 2, 3 },
            });
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void FindJudge_5()
        {
            var solution = new _0997_FindTheTownJudge();
            var result = solution.FindJudge(4, new int[][] {
                new int[] { 1, 3 },
                new int[] { 1, 4 },
                new int[] { 2, 3 },
                new int[] { 2, 4 },
                new int[] { 4, 3 },
            });
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void FindJudge_6()
        {
            var solution = new _0997_FindTheTownJudge();
            var result = solution.FindJudge(1, new int[][] {
            });
            Assert.AreEqual(1, result);
        }
    }
}
