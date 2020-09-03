using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0669_TrimABinarySearchTree_Test
    {
        [TestMethod]
        public void TrimBSTTest_1()
        {
            var root = TestHelper.GenerateTree(new int?[] { 1, 0, 2 });

            var solution = new _0669_TrimABinarySearchTree();
            var newRoot = solution.TrimBST(root, 1, 2);
            AssertHelper.AssertTree(new int?[] { 1, null, 2 }, newRoot);
        }

        [TestMethod]
        public void TrimBSTTest_2()
        {
            var root = TestHelper.GenerateTree(new int?[] { 3, 0, 4, null, 2, null, null, 1, null });

            var solution = new _0669_TrimABinarySearchTree();
            var newRoot = solution.TrimBST(root, 1, 3);
            AssertHelper.AssertTree(new int?[] { 3, 2, null, 1 }, newRoot);
        }
    }
}
