using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0695_MaxAreaOfIsland_Test
    {
        [TestMethod]
        public void MaxAreaOfIslandTest_1()
        {
            var input = new int[][]
            {
                new int[] { 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 },
                new int[] { 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int[] { 0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0 },
                new int[] { 0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0 }
            };

            var solution = new _0695_MaxAreaOfIsland();
            var result = solution.MaxAreaOfIsland(input);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void MaxAreaOfIslandTest_2()
        {
            var input = new int[][]
            {
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0 },
            };

            var solution = new _0695_MaxAreaOfIsland();
            var result = solution.MaxAreaOfIsland(input);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void MaxAreaOfIslandTest_3()
        {
            var input = new int[][]
            {
                new int[] { 0, 0, 0, 0, 1, 0, 0, 0 },
            };

            var solution = new _0695_MaxAreaOfIsland();
            var result = solution.MaxAreaOfIsland(input);
            Assert.AreEqual(1, result);
        }
    }
}
