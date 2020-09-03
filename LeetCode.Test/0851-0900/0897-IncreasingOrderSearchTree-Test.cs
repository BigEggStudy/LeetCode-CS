using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0897_IncreasingOrderSearchTree_Test
    {
        [TestMethod]
        public void IncreasingBST_1()
        {
            var root = TestHelper.GenerateTree(new int?[] { 5, 3, 6, 2, 4, null, 8, 1, null, null, null, 7, 9 });

            var solution = new _0897_IncreasingOrderSearchTree();
            var result = solution.IncreasingBST(root);
            AssertHelper.AssertTree(new int?[] { 1, null, 2, null, 3, null, 4, null, 5, null, 6, null, 7, null, 8, null, 9 }, result);
        }
    }
}
