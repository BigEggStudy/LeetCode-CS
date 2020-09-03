using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _108_ConvertSortedArrayToBinarySearchTree_Test
    {
        [TestMethod]
        public void SortedArrayToBSTTest()
        {
            var solution = new _108_ConvertSortedArrayToBinarySearchTree();
            var result = solution.SortedArrayToBST(new int[] { -10, -3, 0, 5, 9 });
            AssertHelper.AssertTree(new int?[] { 0, -3, 9, -10, null, 5 }, result);
        }

        [TestMethod]
        public void SortedArrayToBSTTest_Empty()
        {
            var solution = new _108_ConvertSortedArrayToBinarySearchTree();
            var result = solution.SortedArrayToBST(new int[] { });
            Assert.IsNull(result);
        }
    }
}
