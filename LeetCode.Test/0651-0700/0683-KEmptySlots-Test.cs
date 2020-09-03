using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0683_KEmptySlots_Test
    {
        [TestMethod]
        public void KEmptySlotsTest_1()
        {
            var solution = new _0683_KEmptySlots();
            var result = solution.KEmptySlots(new int[] { 1, 3, 2 }, 1);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void KEmptySlotsTest_2()
        {
            var solution = new _0683_KEmptySlots();
            var result = solution.KEmptySlots(new int[] { 1, 2, 3 }, 1);
            Assert.AreEqual(-1, result);
        }
    }
}
