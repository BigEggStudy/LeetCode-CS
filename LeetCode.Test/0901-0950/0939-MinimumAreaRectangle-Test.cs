using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0939_MinimumAreaRectangle_Test
    {
        [TestMethod]
        public void MinAreaRectTest_1()
        {
            var solution = new _0939_MinimumAreaRectangle();
            var result = solution.MinAreaRect(
                new int[][] {
                    new int[] { 1, 1 },
                    new int[] { 1, 3 },
                    new int[] { 3, 1 },
                    new int[] { 3, 3 },
                    new int[] { 2, 2 }
                }
            );
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void MinAreaRectTest_2()
        {
            var solution = new _0939_MinimumAreaRectangle();
            var result = solution.MinAreaRect(
                new int[][] {
                    new int[] { 1, 1 },
                    new int[] { 1, 3 },
                    new int[] { 3, 1 },
                    new int[] { 3, 3 },
                    new int[] { 4, 1 },
                    new int[] { 4, 3 },
                }
            );
            Assert.AreEqual(2, result);
        }
    }
}
