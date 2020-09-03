using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0598_RangeAdditionII_Test
    {
        [TestMethod]
        public void MaxCount_1()
        {
            var solution = new _0598_RangeAdditionII();
            var result = solution.MaxCount(3, 2, new int[][] {
                new int[] { 2, 2 },
                new int[] { 3, 3 }
            });
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void MaxCount_2()
        {
            var solution = new _0598_RangeAdditionII();
            var result = solution.MaxCount(26, 17, new int[][] {
                new int[] { 20, 10 },
                new int[] { 26, 11 },
                new int[] { 2, 11 },
                new int[] { 4, 16 },
                new int[] { 2, 3 },
                new int[] { 23, 13 },
                new int[] { 7, 15 },
                new int[] { 11, 11 },
                new int[] { 25, 13 },
                new int[] { 11, 13 },
                new int[] { 13, 11 },
                new int[] { 13, 16 },
                new int[] { 26, 17 }
            });
            Assert.AreEqual(6, result);
        }
    }
}
