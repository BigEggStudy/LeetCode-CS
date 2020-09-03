using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0700_SearchInABinarySearchTree_Test
    {
        [TestMethod]
        public void SearchBST_1()
        {
            var root = TestHelper.GenerateTree(new int?[] { 4, 2, 7, 1, 3 });

            var solution = new _0700_SearchInABinarySearchTree();
            var result = solution.SearchBST(root, 2);
            AssertHelper.AssertTree(new int?[] { 2, 1, 3 }, result);
        }

        [TestMethod]
        public void SearchBST_2()
        {
            var root = TestHelper.GenerateTree(new int?[] { 4, 2, 7, 1, 3 });

            var solution = new _0700_SearchInABinarySearchTree();
            var result = solution.SearchBST(root, 5);
            Assert.IsNull(result);
        }
    }
}
