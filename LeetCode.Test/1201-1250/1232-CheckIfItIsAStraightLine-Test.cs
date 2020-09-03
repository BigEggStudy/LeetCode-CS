using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1232_CheckIfItIsAStraightLine_Test
    {
        [TestMethod]
        public void CheckStraightLine_1()
        {
            var solution = new _1232_CheckIfItIsAStraightLine();
            var result = solution.CheckStraightLine(new int[][] {
                new int[] { 1, 2 },
                new int[] { 2, 3 },
                new int[] { 3, 4 },
                new int[] { 4, 5 },
                new int[] { 5, 6 },
                new int[] { 6, 7 },
            });
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckStraightLine_2()
        {
            var solution = new _1232_CheckIfItIsAStraightLine();
            var result = solution.CheckStraightLine(new int[][] {
                new int[] { 1, 1 },
                new int[] { 2, 2 },
                new int[] { 3, 4 },
                new int[] { 4, 5 },
                new int[] { 5, 6 },
                new int[] { 7, 7 },
            });
            Assert.IsFalse(result);
        }
    }
}
