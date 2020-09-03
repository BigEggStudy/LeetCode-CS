using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0605_CanPlaceFlowers_Test
    {
        [TestMethod]
        public void CanPlaceFlowers_1()
        {
            var solution = new _0605_CanPlaceFlowers();
            var result = solution.CanPlaceFlowers(new int[] { 1, 0, 0, 0, 1 }, 1);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanPlaceFlowers_2()
        {
            var solution = new _0605_CanPlaceFlowers();
            var result = solution.CanPlaceFlowers(new int[] { 1, 0, 0, 0, 1 }, 2);
            Assert.IsFalse(result);
        }
    }
}
