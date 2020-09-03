using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0950_RevealCardsInIncreasingOrder_Test
    {
        [TestMethod]
        public void DeckRevealedIncreasing_1()
        {
            var solution = new _0950_RevealCardsInIncreasingOrder();
            var result = solution.DeckRevealedIncreasing(new int[] { 17, 13, 11, 2, 3, 5, 7 });
            AssertHelper.AssertArray(new int[] { 2, 13, 3, 11, 5, 17, 7 }, result);
        }
    }
}
