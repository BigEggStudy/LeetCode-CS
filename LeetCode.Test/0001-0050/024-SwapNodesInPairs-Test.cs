using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _024_SwapNodesInPairs_Test
    {
        [TestMethod]
        public void SwapPairsTest()
        {
            var input = TestHelper.GenerateList(new int[] { 1, 2, 3, 4 });

            var solution = new _024_SwapNodesInPairs();
            var result = solution.SwapPairs(input);

            AssertHelper.AssertLinkList(new int[] { 2, 1, 4, 3 }, result);
        }

        [TestMethod]
        public void SwapPairsTest_EmptyList()
        {
            var solution = new _024_SwapNodesInPairs();
            var result = solution.SwapPairs(null);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void SwapPairsTest_OnlyOneNode()
        {
            var input = TestHelper.GenerateList(new int[] { 1 });

            var solution = new _024_SwapNodesInPairs();
            var result = solution.SwapPairs(input);

            AssertHelper.AssertLinkList(new int[] { 1 }, result);
        }

        [TestMethod]
        public void SwapPairsTest_NotEnough()
        {
            var input = TestHelper.GenerateList(new int[] { 1, 2, 3 });

            var solution = new _024_SwapNodesInPairs();
            var result = solution.SwapPairs(input);

            AssertHelper.AssertLinkList(new int[] { 2, 1, 3 }, result);
        }
    }
}
