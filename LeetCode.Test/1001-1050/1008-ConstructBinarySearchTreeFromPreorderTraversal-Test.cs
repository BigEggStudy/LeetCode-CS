using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1008_ConstructBinarySearchTreeFromPreorderTraversal_Test
    {
        [TestMethod]
        public void BstFromPreorder_1()
        {
            var solution = new _1008_ConstructBinarySearchTreeFromPreorderTraversal();
            var result = solution.BstFromPreorder(new int[] { 8, 5, 1, 7, 10, 12 });
            AssertHelper.AssertTree(new int?[] { 8, 5, 10, 1, 7, null, 12 }, result);
        }
    }
}
