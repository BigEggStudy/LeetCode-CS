using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _109_ConvertSortedListToBinarySearchTree_Test
    {
        [TestMethod]
        public void SortedListToBSTTest()
        {
            var solution = new _109_ConvertSortedListToBinarySearchTree();
            var result = solution.SortedListToBST(TestHelper.GenerateList(new int[] { -10, -3, 0, 5, 9 }));
            AssertHelper.AssertTree(new int?[] { 0, -3, 9, -10, null, 5 }, result);
        }

        [TestMethod]
        public void SortedArrayToBSTTest_Empty()
        {
            var solution = new _109_ConvertSortedListToBinarySearchTree();
            var result = solution.SortedListToBST(null);
            Assert.IsNull(result);
        }
    }
}
