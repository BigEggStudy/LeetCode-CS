using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1064_FixedPoint_Test
    {
        [TestMethod]
        public void FixedPoint_1()
        {
            var solution = new _1064_FixedPoint();
            var result = solution.FixedPoint(new int[] { -10, -5, 0, 3, 7 });
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void FixedPoint_2()
        {
            var solution = new _1064_FixedPoint();
            var result = solution.FixedPoint(new int[] { 0, 2, 5, 8, 17 });
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void FixedPoint_3()
        {
            var solution = new _1064_FixedPoint();
            var result = solution.FixedPoint(new int[] { -10, -5, 3, 4, 7, 9 });
            Assert.AreEqual(-1, result);
        }
    }
}
