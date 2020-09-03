using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1326_MinimumNumberOfTapsToOpenToWaterAGarden_Test
    {
        [TestMethod]
        public void MinTaps_1()
        {
            var solution = new _1326_MinimumNumberOfTapsToOpenToWaterAGarden();
            var result = solution.MinTaps(5, new int[] { 3, 4, 1, 1, 0, 0 });
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void MinTaps_2()
        {
            var solution = new _1326_MinimumNumberOfTapsToOpenToWaterAGarden();
            var result = solution.MinTaps(3, new int[] { 0, 0, 0, 0 });
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void MinTaps_3()
        {
            var solution = new _1326_MinimumNumberOfTapsToOpenToWaterAGarden();
            var result = solution.MinTaps(7, new int[] { 1, 2, 1, 0, 2, 1, 0, 1 });
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void MinTaps_4()
        {
            var solution = new _1326_MinimumNumberOfTapsToOpenToWaterAGarden();
            var result = solution.MinTaps(8, new int[] { 4, 0, 0, 0, 0, 0, 0, 0, 4 });
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void MinTaps_5()
        {
            var solution = new _1326_MinimumNumberOfTapsToOpenToWaterAGarden();
            var result = solution.MinTaps(8, new int[] { 4, 0, 0, 0, 4, 0, 0, 0, 4 });
            Assert.AreEqual(1, result);
        }
    }
}
