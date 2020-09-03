using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _088_MergeSortedArray_Test
    {
        [TestMethod]
        public void MergeTest()
        {
            var nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            var nums2 = new int[] { 2, 5, 6 };

            var solution = new _088_MergeSortedArray();
            solution.Merge(nums1, 3, nums2, 3);
            AssertHelper.AssertArray(new int[] { 1, 2, 2, 3, 5, 6 }, nums1);
        }

        [TestMethod]
        public void MergeTest_Nums1Empty()
        {
            var nums1 = new int[] { 0, 0, 0 };
            var nums2 = new int[] { 2, 5, 6 };

            var solution = new _088_MergeSortedArray();
            solution.Merge(nums1, 0, nums2, 3);
            AssertHelper.AssertArray(new int[] { 2, 5, 6 }, nums1);
        }

        [TestMethod]
        public void MergeTest_Nums2Empty()
        {
            var nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            var nums2 = new int[] { };

            var solution = new _088_MergeSortedArray();
            solution.Merge(nums1, 3, nums2, 0);
            AssertHelper.AssertArray(new int[] { 1, 2, 3, 0, 0, 0 }, nums1);
        }
    }
}
