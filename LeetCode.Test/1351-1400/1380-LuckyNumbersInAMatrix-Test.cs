using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1380_LuckyNumbersInAMatrix_Test
    {
        [TestMethod]
        public void LuckyNumbers_1()
        {
            var solution = new _1380_LuckyNumbersInAMatrix();
            var result = solution.LuckyNumbers(new int[][] {
                new int[] { 3, 7, 8 },
                new int[] { 9, 11, 13 },
                new int[] { 15, 16, 17 },
            });
            AssertHelper.AssertList(new int[] { 15 }, result);
        }

        [TestMethod]
        public void LuckyNumbers_2()
        {
            var solution = new _1380_LuckyNumbersInAMatrix();
            var result = solution.LuckyNumbers(new int[][] {
                new int[] { 1, 10, 4, 2 },
                new int[] { 9, 3, 8, 7 },
                new int[] { 15, 16, 17, 12 },
            });
            AssertHelper.AssertList(new int[] { 12 }, result);
        }

        [TestMethod]
        public void LuckyNumbers_3()
        {
            var solution = new _1380_LuckyNumbersInAMatrix();
            var result = solution.LuckyNumbers(new int[][] {
                new int[] { 7, 8 },
                new int[] { 1, 2},
            });
            AssertHelper.AssertList(new int[] { 7 }, result);
        }

        [TestMethod]
        public void LuckyNumbers_4()
        {
            var solution = new _1380_LuckyNumbersInAMatrix();
            var result = solution.LuckyNumbers(new int[][] {
                new int[] { 1, 4 },
                new int[] { 3, 2 },
            });
            Assert.AreEqual(0, result.Count);
        }
    }
}
