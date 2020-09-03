using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0236_LowestCommonAncestorOfABinaryTree_Test
    {
        [TestMethod]
        public void LowestCommonAncestor_1()
        {
            var root = TestHelper.GenerateTree(new int?[] { 3, 5, 1, 6, 2, 0, 8, null, null, 7, 4 });

            var solution = new _0236_LowestCommonAncestorOfABinaryTree();
            var result = solution.LowestCommonAncestor(root, root.left, root.right);
            Assert.AreEqual(root, result);
        }

        [TestMethod]
        public void LowestCommonAncestor_2()
        {
            var root = TestHelper.GenerateTree(new int?[] { 3, 5, 1, 6, 2, 0, 8, null, null, 7, 4 });

            var solution = new _0236_LowestCommonAncestorOfABinaryTree();
            var result = solution.LowestCommonAncestor(root, root.left, root.left.right.right);
            Assert.AreEqual(root.left, result);
        }
    }
}
