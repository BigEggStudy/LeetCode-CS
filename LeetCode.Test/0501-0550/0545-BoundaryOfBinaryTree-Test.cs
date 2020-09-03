using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0545_BoundaryOfBinaryTree_Test
    {
        [TestMethod]
        public void BoundaryOfBinaryTree_1()
        {
            var root = TestHelper.GenerateTree(new int?[] { 1, null, 2, 3, 4 });

            var solution = new _0545_BoundaryOfBinaryTree();
            var result = solution.BoundaryOfBinaryTree(root);
            AssertHelper.AssertList(new int[] { 1, 3, 4, 2 }, result);
        }

        [TestMethod]
        public void BoundaryOfBinaryTree_2()
        {
            var root = TestHelper.GenerateTree(new int?[] { 1, 2, 3, 4, 5, 6, null, null, null, 7, 8, 9, 10 });

            var solution = new _0545_BoundaryOfBinaryTree();
            var result = solution.BoundaryOfBinaryTree(root);
            AssertHelper.AssertList(new int[] { 1, 2, 4, 7, 8, 9, 10, 6, 3 }, result);
        }
    }
}
