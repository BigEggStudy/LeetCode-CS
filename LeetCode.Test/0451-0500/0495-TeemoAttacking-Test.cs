using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0495_TeemoAttacking_Test
    {
        [TestMethod]
        public void FindPoisonedDuration_1()
        {
            var solution = new _0495_TeemoAttacking();
            var result = solution.FindPoisonedDuration(new int[] { 1, 4 }, 2);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void FindPoisonedDuration_2()
        {
            var solution = new _0495_TeemoAttacking();
            var result = solution.FindPoisonedDuration(new int[] { 1, 2 }, 2);
            Assert.AreEqual(3, result);
        }
    }
}
