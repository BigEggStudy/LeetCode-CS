using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0747_LargestNumberAtLeastTwiceOfOthers_Test
    {
        [TestMethod]
        public void DominantIndex_1()
        {
            var solution = new _0747_LargestNumberAtLeastTwiceOfOthers();
            var result = solution.DominantIndex(new int[] { 3, 6, 1, 0 });
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void DominantIndex_2()
        {
            var solution = new _0747_LargestNumberAtLeastTwiceOfOthers();
            var result = solution.DominantIndex(new int[] { 1, 2, 3, 4 });
            Assert.AreEqual(-1, result);
        }
    }
}
