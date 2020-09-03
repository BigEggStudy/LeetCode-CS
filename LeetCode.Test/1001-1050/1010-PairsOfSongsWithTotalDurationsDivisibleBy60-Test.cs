using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1010_PairsOfSongsWithTotalDurationsDivisibleBy60_Test
    {
        [TestMethod]
        public void NumPairsDivisibleBy60_1()
        {
            var solution = new _1010_PairsOfSongsWithTotalDurationsDivisibleBy60();
            var result = solution.NumPairsDivisibleBy60(new int[] { 30, 20, 150, 100, 40 });
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void NumPairsDivisibleBy60_2()
        {
            var solution = new _1010_PairsOfSongsWithTotalDurationsDivisibleBy60();
            var result = solution.NumPairsDivisibleBy60(new int[] { 60, 60, 60 });
            Assert.AreEqual(3, result);
        }
    }
}
