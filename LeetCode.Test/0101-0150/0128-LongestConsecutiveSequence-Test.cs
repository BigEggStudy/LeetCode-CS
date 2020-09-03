using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0128_LongestConsecutiveSequence_Test
    {
        [TestMethod]
        public void LongestConsecutiveTest_1()
        {
            var solution = new _0128_LongestConsecutiveSequence();
            var result = solution.LongestConsecutive(new int[] { 100, 4, 200, 1, 3, 2 });
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void LongestConsecutiveTest_2()
        {
            var solution = new _0128_LongestConsecutiveSequence();
            var result = solution.LongestConsecutive(new int[] { 100, 4, 200, 1, 3, 2, 4 });
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void LongestConsecutiveTest_3()
        {
            var solution = new _0128_LongestConsecutiveSequence();
            var result = solution.LongestConsecutive(new int[] { 100, 4, 100, 1, 3, 2, 4 });
            Assert.AreEqual(4, result);
        }
    }
}
