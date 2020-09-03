using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1038_BinarySearchTreeToGreaterSumTree_Test
    {
        [TestMethod]
        public void BstToGst_1()
        {
            var root = TestHelper.GenerateTree(new int?[] { 4, 1, 6, 0, 2, 5, 7, null, null, null, 3, null, null, null, 8 });

            var solution = new _1038_BinarySearchTreeToGreaterSumTree();
            var result = solution.BstToGst(root);
            AssertHelper.AssertTree(new int?[] { 30, 36, 21, 36, 35, 26, 15, null, null, null, 33, null, null, null, 8 }, result);
        }

        [TestMethod]
        public void BstToGst_2()
        {
            var root = TestHelper.GenerateTree(new int?[] { 5, 2, 13 });

            var solution = new _1038_BinarySearchTreeToGreaterSumTree();
            var result = solution.BstToGst(root);
            AssertHelper.AssertTree(new int?[] { 18, 20, 13 }, result);
        }
    }
}
