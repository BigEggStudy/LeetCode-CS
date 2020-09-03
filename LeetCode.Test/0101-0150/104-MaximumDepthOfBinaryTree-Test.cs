using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _104_MaximumDepthOfBinaryTree_Test
    {
        [TestMethod]
        public void MaxDepthTest()
        {
            var solution = new _104_MaximumDepthOfBinaryTree();
            var result = solution.MaxDepth(TestHelper.GenerateTree(new int?[] { 3, 9, 20, null, null, 15, 7 }));
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void MaxDepthTest_Null()
        {
            var solution = new _104_MaximumDepthOfBinaryTree();
            var result = solution.MaxDepth(null);
            Assert.AreEqual(0, result);
        }
    }
}
