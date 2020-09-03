using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1385_FindTheDistanceValueBetweenTwoArrays_Test
    {
        [TestMethod]
        public void FindTheDistanceValue_1()
        {
            var solution = new _1385_FindTheDistanceValueBetweenTwoArrays();
            var result = solution.FindTheDistanceValue(new int[] { 4, 5, 8 }, new int[] { 10, 9, 1, 8 }, 2);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void FindTheDistanceValue_2()
        {
            var solution = new _1385_FindTheDistanceValueBetweenTwoArrays();
            var result = solution.FindTheDistanceValue(new int[] { 1, 4, 2, 3 }, new int[] { -4, -3, 6, 10, 20, 30 }, 3);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void FindTheDistanceValue_3()
        {
            var solution = new _1385_FindTheDistanceValueBetweenTwoArrays();
            var result = solution.FindTheDistanceValue(new int[] { 2, 1, 100, 3 }, new int[] { -5, -2, 10, -3, 7 }, 6);
            Assert.AreEqual(1, result);
        }
    }
}
