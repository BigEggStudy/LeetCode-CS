using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0235_LowestCommonAncestorOfABinarySearchTree_Test
    {
        [TestMethod]
        public void LowestCommonAncestorTest_1()
        {
            var root = TestHelper.GenerateTree(new int?[] { 6, 2, 8, 0, 4, 7, 9, null, null, 3, 5 });
            var p = new TreeNode(2);
            var q = new TreeNode(8);

            var solution = new _0235_LowestCommonAncestorOfABinarySearchTree();
            var result = solution.LowestCommonAncestor(root, p, q);
            Assert.AreEqual(6, result.val);
        }

        [TestMethod]
        public void LowestCommonAncestorTest_2()
        {
            var root = TestHelper.GenerateTree(new int?[] { 6, 2, 8, 0, 4, 7, 9, null, null, 3, 5 });
            var p = new TreeNode(2);
            var q = new TreeNode(4);

            var solution = new _0235_LowestCommonAncestorOfABinarySearchTree();
            var result = solution.LowestCommonAncestor(root, p, q);
            Assert.AreEqual(2, result.val);
        }
    }
}
