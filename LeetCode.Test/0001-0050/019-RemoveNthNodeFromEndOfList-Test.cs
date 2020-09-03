using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _019_RemoveNthNodeFromEndOfList_Test
    {
        [TestMethod]
        public void RemoveNthFromEndTest()
        {
            var input = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _019_RemoveNthNodeFromEndOfList();
            var result = solution.RemoveNthFromEnd(input, 2);

            AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 5 }, result);
        }

        [TestMethod]
        public void RemoveNthFromEndTest_ListNull()
        {
            var solution = new _019_RemoveNthNodeFromEndOfList();
            var result = solution.RemoveNthFromEnd(null, 2);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void RemoveNthFromEndTest_NEqualZero()
        {
            var input = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _019_RemoveNthNodeFromEndOfList();
            var result = solution.RemoveNthFromEnd(input, 0);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void RemoveNthFromEndTest_NLessThanZero()
        {
            var input = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _019_RemoveNthNodeFromEndOfList();
            var result = solution.RemoveNthFromEnd(input, -1);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void RemoveNthFromEndTest_LargerThanList()
        {
            var input = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _019_RemoveNthNodeFromEndOfList();
            var result = solution.RemoveNthFromEnd(input, 6);

            AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 4, 5 }, result);
        }

        [TestMethod]
        public void RemoveNthFromEndTest_FirstOne()
        {
            var input = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _019_RemoveNthNodeFromEndOfList();
            var result = solution.RemoveNthFromEnd(input, 5);

            AssertHelper.AssertLinkList(new int[] { 2, 3, 4, 5 }, result);
        }

        [TestMethod]
        public void RemoveNthFromEndTest_LastOne()
        {
            var input = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _019_RemoveNthNodeFromEndOfList();
            var result = solution.RemoveNthFromEnd(input, 1);

            AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 4 }, result);
        }
    }
}
