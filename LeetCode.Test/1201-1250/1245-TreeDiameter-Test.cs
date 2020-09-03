using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1245_TreeDiameter_Test
    {
        [TestMethod]
        public void TreeDiameter_1()
        {
            var solution = new _1245_TreeDiameter();
            var result = solution.TreeDiameter(new int[][] {
                new int[] { 0, 1 },
                new int[] { 0, 2 },
            });
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TreeDiameter_2()
        {
            var solution = new _1245_TreeDiameter();
            var result = solution.TreeDiameter(new int[][] {
                new int[] { 0, 1 },
                new int[] { 1, 2 },
                new int[] { 2, 3 },
                new int[] { 1, 4 },
                new int[] { 4, 5 },
            });
            Assert.AreEqual(4, result);
        }
    }
}
