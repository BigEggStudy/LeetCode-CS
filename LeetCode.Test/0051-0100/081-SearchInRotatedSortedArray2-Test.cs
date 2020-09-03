using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _081_SearchInRotatedSortedArray2_Test
    {
        [TestMethod]
        public void SearchTest_TargetLessThanMid_Rotated()
        {
            var input = new int[] { 4, 5, 6, 7, 0, 1, 2 };

            var solution = new _081_SearchInRotatedSortedArray2();
            var result = solution.Search(input, 1);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SearchTest_TargetLessThanMid_Rotated_2()
        {
            var input = new int[] { 7, 8, 0, 1, 2, 4, 5, 6 };

            var solution = new _081_SearchInRotatedSortedArray2();
            var result = solution.Search(input, 0);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SearchTest_TargetLessThanMid_NoRotated()
        {
            var input = new int[] { 4, 5, 6, 7, 0, 1, 2 };

            var solution = new _081_SearchInRotatedSortedArray2();
            var result = solution.Search(input, 5);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SearchTest_TargetLargeThanMid_Rotated()
        {
            var input = new int[] { 6, 7, 0, 1, 2, 4, 5 };

            var solution = new _081_SearchInRotatedSortedArray2();
            var result = solution.Search(input, 7);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SearchTest_TargetLargeThanMid_Rotated_2()
        {
            var input = new int[] { 4, 5, 6, 7, 8, 0, 1, 2 };

            var solution = new _081_SearchInRotatedSortedArray2();
            var result = solution.Search(input, 8);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SearchTest_TargetLargeThanMid_NoRotated()
        {
            var input = new int[] { 6, 7, 0, 1, 2, 4, 5 };

            var solution = new _081_SearchInRotatedSortedArray2();
            var result = solution.Search(input, 4);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SearchTest_NotFound()
        {
            var input = new int[] { 6, 7, 0, 1, 2, 4, 5 };

            var solution = new _081_SearchInRotatedSortedArray2();
            var result = solution.Search(input, 8);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void SearchTest_SmallArray()
        {
            var input = new int[] { 3, 1 };

            var solution = new _081_SearchInRotatedSortedArray2();
            var result = solution.Search(input, 1);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SearchTest_SmallArray_2()
        {
            var input = new int[] { 1, 3 };

            var solution = new _081_SearchInRotatedSortedArray2();
            var result = solution.Search(input, 3);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SearchTest_WithDuplicate_2()
        {
            var input = new int[] { 1, 3, 1, 1, 1 };

            var solution = new _081_SearchInRotatedSortedArray2();
            var result = solution.Search(input, 3);

            Assert.IsTrue(result);
        }
    }
}
