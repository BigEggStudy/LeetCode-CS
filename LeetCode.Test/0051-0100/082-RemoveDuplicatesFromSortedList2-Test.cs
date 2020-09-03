using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _082_RemoveDuplicatesFromSortedList2_Test
    {
        [TestMethod]
        public void DeleteDuplicatesTest_WithoutDuplicate()
        {
            var input = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _082_RemoveDuplicatesFromSortedList2();
            var result = solution.DeleteDuplicates(input);

            AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 4, 5 }, result);
        }

        [TestMethod]
        public void DeleteDuplicatesTest_WithDuplicate()
        {
            var input = TestHelper.GenerateList(new int[] { 1, 2, 3, 3, 4, 5 });

            var solution = new _082_RemoveDuplicatesFromSortedList2();
            var result = solution.DeleteDuplicates(input);

            AssertHelper.AssertLinkList(new int[] { 1, 2, 4, 5 }, result);
        }

        [TestMethod]
        public void DeleteDuplicatesTest_WithMultipleDuplicate()
        {
            var input = TestHelper.GenerateList(new int[] { 1, 2, 3, 3, 4, 4, 5 });

            var solution = new _082_RemoveDuplicatesFromSortedList2();
            var result = solution.DeleteDuplicates(input);

            AssertHelper.AssertLinkList(new int[] { 1, 2, 5 }, result);
        }

        [TestMethod]
        public void DeleteDuplicatesTest_StartWithDuplicate()
        {
            var input = TestHelper.GenerateList(new int[] { 1, 1, 1, 2, 3, 4, 5 });

            var solution = new _082_RemoveDuplicatesFromSortedList2();
            var result = solution.DeleteDuplicates(input);

            AssertHelper.AssertLinkList(new int[] { 2, 3, 4, 5 }, result);
        }

        [TestMethod]
        public void DeleteDuplicatesTest_EndWithDuplicate()
        {
            var input = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5, 5, 5 });

            var solution = new _082_RemoveDuplicatesFromSortedList2();
            var result = solution.DeleteDuplicates(input);

            AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 4 }, result);
        }

        [TestMethod]
        public void DeleteDuplicatesTest_AllTheSame()
        {
            var input = TestHelper.GenerateList(new int[] { 1, 1, 1, 1, 1 });

            var solution = new _082_RemoveDuplicatesFromSortedList2();
            var result = solution.DeleteDuplicates(input);

            Assert.IsNull(result);
        }
    }
}
