using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0814_BinaryTreePruning_Test
    {
        [TestMethod]
        public void PruneTree_1()
        {
            var root = TestHelper.GenerateTree(new int?[] { 1, null, 0, 0, 1 });

            var solution = new _0814_BinaryTreePruning();
            var result = solution.PruneTree(root);
            AssertHelper.AssertTree(new int?[] { 1, null, 0, null, 1 }, result);
        }

        [TestMethod]
        public void PruneTree_2()
        {
            var root = TestHelper.GenerateTree(new int?[] { 1, 0, 1, 0, 0, 0, 1 });

            var solution = new _0814_BinaryTreePruning();
            var result = solution.PruneTree(root);
            AssertHelper.AssertTree(new int?[] { 1, null, 1, null, 1 }, result);
        }

        [TestMethod]
        public void PruneTree_3()
        {
            var root = TestHelper.GenerateTree(new int?[] { 1, 1, 0, 1, 1, 0, 1, 0 });

            var solution = new _0814_BinaryTreePruning();
            var result = solution.PruneTree(root);
            AssertHelper.AssertTree(new int?[] { 1, 1, 0, 1, 1, null, 1 }, result);
        }
    }
}
