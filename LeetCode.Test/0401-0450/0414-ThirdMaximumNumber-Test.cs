using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0414_ThirdMaximumNumber_Test
    {
        [TestMethod]
        public void ThirdMax_1()
        {
            var solution = new _0414_ThirdMaximumNumber();
            var result = solution.ThirdMax(new int[] { 3, 2, 1 });
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ThirdMax_2()
        {
            var solution = new _0414_ThirdMaximumNumber();
            var result = solution.ThirdMax(new int[] { 1, 2 });
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void ThirdMax_3()
        {
            var solution = new _0414_ThirdMaximumNumber();
            var result = solution.ThirdMax(new int[] { 2, 2, 3, 1 });
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ThirdMax_4()
        {
            var solution = new _0414_ThirdMaximumNumber();
            var result = solution.ThirdMax(new int[] { 2, 2, 2, 1 });
            Assert.AreEqual(2, result);
        }
    }
}
