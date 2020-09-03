using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _023_MergeKSortedLists_Test
    {
        [TestMethod]
        public void MergeKListsTest()
        {
            var input = new ListNode[] {
                TestHelper.GenerateList(new int[] { 1, 3, 5, 7, 9 }),
                TestHelper.GenerateList(new int[] { 2, 4, 6, 8, 10 })
            };

            var solution = new _023_MergeKSortedLists();
            var result = solution.MergeKLists(input);

            AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, result);
        }

        [TestMethod]
        public void MergeKListsTest_2()
        {
            var input = new ListNode[] {
                TestHelper.GenerateList(new int[] { 1, 3, 7 }),
                TestHelper.GenerateList(new int[] { 2, 10 }),
                TestHelper.GenerateList(new int[] { 5, 9 }),
                TestHelper.GenerateList(new int[] { 4, 6, 8})
            };

            var solution = new _023_MergeKSortedLists();
            var result = solution.MergeKLists(input);

            AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, result);
        }

        [TestMethod]
        public void MergeKListsTest_OneList()
        {
            var input = new ListNode[] {
                TestHelper.GenerateList(new int[] { 1, 2, 3 })
            };

            var solution = new _023_MergeKSortedLists();
            var result = solution.MergeKLists(input);

            AssertHelper.AssertLinkList(new int[] { 1, 2, 3 }, result);
        }

        [TestMethod]
        public void MergeKListsTest_EmptyList()
        {
            var input = new ListNode[] { };

            var solution = new _023_MergeKSortedLists();
            var result = solution.MergeKLists(input);

            Assert.IsNull(result);
        }
    }
}
