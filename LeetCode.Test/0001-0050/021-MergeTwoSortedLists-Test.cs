using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _021_MergeTwoSortedLists_Test
    {
        [TestMethod]
        public void MergeTwoListsTest()
        {
            var list1 = TestHelper.GenerateList(new int[] { 1, 3, 5, 7, 9 });
            var list2 = TestHelper.GenerateList(new int[] { 2, 4, 6, 8, 10 });

            var solution = new _021_MergeTwoSortedLists();
            var result = solution.MergeTwoLists(list1, list2);

            AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, result);
        }

        [TestMethod]
        public void MergeTwoListsTest_List1Longer()
        {
            var list1 = TestHelper.GenerateList(new int[] { 1, 3, 5, 7, 9, 11, 13 });
            var list2 = TestHelper.GenerateList(new int[] { 2, 4, 6, 8, 10 });

            var solution = new _021_MergeTwoSortedLists();
            var result = solution.MergeTwoLists(list1, list2);

            AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 13 }, result);
        }

        [TestMethod]
        public void MergeTwoListsTest_List2Longer()
        {
            var list1 = TestHelper.GenerateList(new int[] { 1, 3, 5, 7, 9 });
            var list2 = TestHelper.GenerateList(new int[] { 2, 4, 6, 8, 10, 12, 14 });

            var solution = new _021_MergeTwoSortedLists();
            var result = solution.MergeTwoLists(list1, list2);

            AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 14 }, result);
        }

        [TestMethod]
        public void MergeTwoListsTest_List1Empty()
        {
            var list2 = TestHelper.GenerateList(new int[] { 2, 4, 6, 8, 10 });

            var solution = new _021_MergeTwoSortedLists();
            var result = solution.MergeTwoLists(null, list2);

            AssertHelper.AssertLinkList(new int[] { 2, 4, 6, 8, 10 }, result);
        }

        [TestMethod]
        public void MergeTwoListsTest_List2Empty()
        {
            var list1 = TestHelper.GenerateList(new int[] { 1, 3, 5, 7, 9 });

            var solution = new _021_MergeTwoSortedLists();
            var result = solution.MergeTwoLists(list1, null);

            AssertHelper.AssertLinkList(new int[] { 1, 3, 5, 7, 9 }, result);
        }

        [TestMethod]
        public void MergeTwoListsTest_BothListEmpty()
        {
            var solution = new _021_MergeTwoSortedLists();
            var result = solution.MergeTwoLists(null, null);
            Assert.IsNull(result);
        }
    }
}
