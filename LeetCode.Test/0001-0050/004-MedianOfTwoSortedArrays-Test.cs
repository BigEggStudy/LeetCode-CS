using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _004_MedianOfTwoSortedArrays_Test
    {
        [TestMethod]
        public void FindMedianSortedArraysTest_General_Odd()
        {
            int[] nums1 = { 1, 2 };
            int[] nums2 = { 3, 4, 5 };

            var solution = new _004_MedianOfTwoSortedArrays();
            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void FindMedianSortedArraysTest_General_Even()
        {
            int[] nums1 = { 1, 2, 3, 4 };
            int[] nums2 = { 5, 6, 7, 8 };

            var solution = new _004_MedianOfTwoSortedArrays();
            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(4.5, result);
        }

        [TestMethod]
        public void FindMedianSortedArraysTest_Num1Empty()
        {
            int[] nums1 = { };
            int[] nums2 = { 1, 2, 3 };

            var solution = new _004_MedianOfTwoSortedArrays();
            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void FindMedianSortedArraysTest_Num2Empty()
        {
            int[] nums1 = { 1, 2, 3 };
            int[] nums2 = { };

            var solution = new _004_MedianOfTwoSortedArrays();
            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void FindMedianSortedArraysTest_Num1Empty_Nums2SingleItem()
        {
            int[] nums1 = { };
            int[] nums2 = { 1 };

            var solution = new _004_MedianOfTwoSortedArrays();
            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void FindMedianSortedArraysTest_Num2Empty_Nums1SingleItem()
        {
            int[] nums1 = { 1 };
            int[] nums2 = { };

            var solution = new _004_MedianOfTwoSortedArrays();
            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void FindMedianSortedArraysTest_Nums1SingleItem_Odd()
        {
            int[] nums1 = { 1 };
            int[] nums2 = { 2, 3, 4, 5, 6, 7 };

            var solution = new _004_MedianOfTwoSortedArrays();
            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void FindMedianSortedArraysTest_Nums1SingleItem_Even()
        {
            int[] nums1 = { 1 };
            int[] nums2 = { 2, 3, 4, 5, 6 };

            var solution = new _004_MedianOfTwoSortedArrays();
            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(3.5, result);
        }

        [TestMethod]
        public void FindMedianSortedArraysTest_Nums2SingleItem_Odd()
        {
            int[] nums1 = { 2, 3, 4, 5, 6, 7 };
            int[] nums2 = { 1 };

            var solution = new _004_MedianOfTwoSortedArrays();
            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void FindMedianSortedArraysTest_Nums2SingleItem_Even()
        {
            int[] nums1 = { 2, 3, 4, 5, 6 };
            int[] nums2 = { 1 };

            var solution = new _004_MedianOfTwoSortedArrays();
            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(3.5, result);
        }

        [TestMethod]
        public void FindMedianSortedArraysTest_MixedArray()
        {
            int[] nums1 = { 2 };
            int[] nums2 = { 1, 3, 4 };

            var solution = new _004_MedianOfTwoSortedArrays();
            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(2.5, result);
        }

        [TestMethod]
        public void FindMedianSortedArraysTest_DuplicateItems()
        {
            int[] nums1 = { 1, 1, 3, 3 };
            int[] nums2 = { 1, 1, 3, 3 };

            var solution = new _004_MedianOfTwoSortedArrays();
            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void FindMedianSortedArraysTest_DuplicateItems_2()
        {
            int[] nums1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };
            int[] nums2 = { 0, 6 };

            var solution = new _004_MedianOfTwoSortedArrays();
            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(10.5, result);
        }
    }
}
