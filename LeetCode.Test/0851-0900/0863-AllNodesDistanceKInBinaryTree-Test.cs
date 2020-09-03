using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0863_AllNodesDistanceKInBinaryTree_Test
    {
        [TestMethod]
        public void DistanceK_1()
        {
            var root = TestHelper.GenerateTree(new int?[] { 3, 5, 1, 6, 2, 0, 8, null, null, 7, 4 });

            var solution = new _0863_AllNodesDistanceKInBinaryTree();
            var result = solution.DistanceK(root, root.left, 2);
            AssertHelper.AssertList(new int[] { 1, 7, 4 }, result);
        }

        [TestMethod]
        public void DistanceK_2()
        {
            var root = TestHelper.GenerateTree(new int?[] { 1 });

            var solution = new _0863_AllNodesDistanceKInBinaryTree();
            var result = solution.DistanceK(root, root, 3);
            AssertHelper.AssertList(new int[] { }, result);
        }

        [TestMethod]
        public void DistanceK_3()
        {
            var root = TestHelper.GenerateTree(new int?[] { 0, 1, null, null, 2, null, 3, null, 4 });

            var solution = new _0863_AllNodesDistanceKInBinaryTree();
            var result = solution.DistanceK(root, root.left.right.right, 0);
            AssertHelper.AssertList(new int[] { 3 }, result);
        }
    }
}
