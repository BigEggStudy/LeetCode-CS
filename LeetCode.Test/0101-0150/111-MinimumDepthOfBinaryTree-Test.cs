using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _111_MinimumDepthOfBinaryTree_Test
    {
        [TestMethod]
        public void MinDepthTest_1Layer()
        {
            var solution = new _111_MinimumDepthOfBinaryTree();
            var result = solution.MinDepth(TestHelper.GenerateTree(new int?[] { 1 }));
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void MinDepthTest_2Layer()
        {
            var solution = new _111_MinimumDepthOfBinaryTree();
            var result = solution.MinDepth(TestHelper.GenerateTree(new int?[] { 1, 2 }));
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void MinDepthTest_3Layer()
        {
            var solution = new _111_MinimumDepthOfBinaryTree();
            var result = solution.MinDepth(TestHelper.GenerateTree(new int?[] { 3, 9, 20, null, null, 15, 7 }));
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void MinDepthTest_Null()
        {
            var solution = new _111_MinimumDepthOfBinaryTree();
            var result = solution.MinDepth(null);
            Assert.AreEqual(0, result);
        }
    }
}
