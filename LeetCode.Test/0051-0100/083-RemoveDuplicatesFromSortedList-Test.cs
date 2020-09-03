using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _083_RemoveDuplicatesFromSortedList_Test
    {
        [TestMethod]
        public void DeleteDuplicatesTest_WithoutDuplicate()
        {
            var input = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _083_RemoveDuplicatesFromSortedList();
            var result = solution.DeleteDuplicates(input);

            AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 4, 5 }, result);
        }

        [TestMethod]
        public void DeleteDuplicatesTest_WithDuplicate()
        {
            var input = TestHelper.GenerateList(new int[] { 1, 2, 3, 3, 4, 5 });

            var solution = new _083_RemoveDuplicatesFromSortedList();
            var result = solution.DeleteDuplicates(input);

            AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 4, 5 }, result);
        }

        [TestMethod]
        public void DeleteDuplicatesTest_WithMultipleDuplicate()
        {
            var input = TestHelper.GenerateList(new int[] { 1, 2, 3, 3, 4, 4, 5 });

            var solution = new _083_RemoveDuplicatesFromSortedList();
            var result = solution.DeleteDuplicates(input);

            AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 4, 5 }, result);
        }

        [TestMethod]
        public void DeleteDuplicatesTest_StartWithDuplicate()
        {
            var input = TestHelper.GenerateList(new int[] { 1, 1, 1, 2, 3, 4, 5 });

            var solution = new _083_RemoveDuplicatesFromSortedList();
            var result = solution.DeleteDuplicates(input);

            AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 4, 5 }, result);
        }

        [TestMethod]
        public void DeleteDuplicatesTest_EndWithDuplicate()
        {
            var input = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5, 5, 5 });

            var solution = new _083_RemoveDuplicatesFromSortedList();
            var result = solution.DeleteDuplicates(input);

            AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 4, 5 }, result);
        }

        [TestMethod]
        public void DeleteDuplicatesTest_AllTheSame()
        {
            var input = TestHelper.GenerateList(new int[] { 1, 1, 1, 1, 1 });

            var solution = new _083_RemoveDuplicatesFromSortedList();
            var result = solution.DeleteDuplicates(input);

            AssertHelper.AssertLinkList(new int[] { 1 }, result);
        }
    }
}
