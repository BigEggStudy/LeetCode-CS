using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1476_SubrectangleQueries_Test
    {
        [TestMethod]
        public void SubrectangleQueries_1()
        {
            var solution = new _1476_SubrectangleQueries(new int[][] {
                new int[] { 1, 2, 1 },
                new int[] { 4, 3, 4 },
                new int[] { 3, 2, 1 },
                new int[] { 1, 1, 1 },
            });

            Assert.AreEqual(1, solution.GetValue(0, 2)); // return 1
            solution.UpdateSubrectangle(0, 0, 3, 2, 5);
            Assert.AreEqual(5, solution.GetValue(0, 2)); // return 5
            Assert.AreEqual(5, solution.GetValue(3, 1)); // return 5
            solution.UpdateSubrectangle(3, 0, 3, 2, 10);
            Assert.AreEqual(10, solution.GetValue(3, 1)); // return 10
            Assert.AreEqual(5, solution.GetValue(0, 2)); // return 5
        }

        [TestMethod]
        public void SubrectangleQueries_2()
        {
            var solution = new _1476_SubrectangleQueries(new int[][] {
                new int[] { 1, 1, 1 },
                new int[] { 2, 2, 2 },
                new int[] { 3, 3, 3 },
            });

            Assert.AreEqual(1, solution.GetValue(0, 0));
            solution.UpdateSubrectangle(0, 0, 2, 2, 100);
            Assert.AreEqual(100, solution.GetValue(0, 0));
            Assert.AreEqual(100, solution.GetValue(2, 2));
            solution.UpdateSubrectangle(1, 1, 2, 2, 20);
            Assert.AreEqual(20, solution.GetValue(2, 2));
        }
    }
}
