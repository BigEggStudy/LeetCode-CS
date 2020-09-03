using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0846_HandOfStraights_Test
    {
        [TestMethod]
        public void IsNStraightHand_1()
        {
            var solution = new _0846_HandOfStraights();
            var result = solution.IsNStraightHand(new int[] { 1, 2, 3, 6, 2, 3, 4, 7, 8 }, 3);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNStraightHand_2()
        {
            var solution = new _0846_HandOfStraights();
            var result = solution.IsNStraightHand(new int[] { 1, 2, 3, 4, 5 }, 4);
            Assert.IsFalse(result);
        }
    }
}
