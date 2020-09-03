using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0543_DiameterOfBinaryTree_Test
    {
        [TestMethod]
        public void DiameterOfBinaryTreeTest()
        {
            var root = TestHelper.GenerateTree(new int?[] { 1, 2, 3, 4, 5 });

            var solution = new _0543_DiameterOfBinaryTree();
            var result = solution.DiameterOfBinaryTree(root);
            Assert.AreEqual(3, result);
        }
    }
}
