using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0437_PathSumIII_Test
    {
        [TestMethod]
        public void PathSum_1()
        {
            var root = TestHelper.GenerateTree(new int?[] { 10, 5, -3, 3, 2, null, 11, 3, -2, null, 1 });

            var solution = new _0437_PathSumIII();
            var result = solution.PathSum(root, 8);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void PathSum_2()
        {
            var root = TestHelper.GenerateTree(new int?[] { 2, 5, -3, 3, 2, null, 11, 3, -2, null, 1 });

            var solution = new _0437_PathSumIII();
            var result = solution.PathSum(root, 8);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void PathSum_3()
        {
            var root = TestHelper.GenerateTree(new int?[] { 0, 5, -3, 3, 2, null, 11, 3, -2, null, 1 });

            var solution = new _0437_PathSumIII();
            var result = solution.PathSum(root, 8);
            Assert.AreEqual(6, result);
        }
    }
}
