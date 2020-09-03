using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0949_LargestTimeForGivenDigits_Test
    {
        [TestMethod]
        public void LargestTimeFromDigits_1()
        {
            var solution = new _0949_LargestTimeForGivenDigits();
            var result = solution.LargestTimeFromDigits(new int[] { 1, 2, 3, 4 });
            Assert.AreEqual("23:41", result);
        }

        [TestMethod]
        public void LargestTimeFromDigits_2()
        {
            var solution = new _0949_LargestTimeForGivenDigits();
            var result = solution.LargestTimeFromDigits(new int[] { 5, 5, 5, 5 });
            Assert.AreEqual("", result);
        }
    }
}
