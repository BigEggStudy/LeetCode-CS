using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0257_BinaryTreePaths_Test
    {
        [TestMethod]
        public void BinaryTreePaths_1()
        {
            var root = TestHelper.GenerateTree(new int?[] { 1, 2, 3, null, 5 });

            var solution = new _0257_BinaryTreePaths();
            var result = solution.BinaryTreePaths(root);
            AssertHelper.AssertList(new string[] { "1->2->5", "1->3" }, result);
        }

        [TestMethod]
        public void BinaryTreePaths_2()
        {
            var root = TestHelper.GenerateTree(new int?[] { 1, 2, 3, 4, 5 });

            var solution = new _0257_BinaryTreePaths();
            var result = solution.BinaryTreePaths(root);
            AssertHelper.AssertList(new string[] { "1->2->4", "1->2->5", "1->3" }, result);
        }
    }
}
