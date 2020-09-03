using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1375_BulbSwitcherIII_Test
    {
        [TestMethod]
        public void NumTimesAllBlue_1()
        {
            var solution = new _1375_BulbSwitcherIII();
            var result = solution.NumTimesAllBlue(new int[] { 2, 1, 3, 5, 4 });
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void NumTimesAllBlue_2()
        {
            var solution = new _1375_BulbSwitcherIII();
            var result = solution.NumTimesAllBlue(new int[] { 3, 2, 4, 1, 5 });
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void NumTimesAllBlue_3()
        {
            var solution = new _1375_BulbSwitcherIII();
            var result = solution.NumTimesAllBlue(new int[] { 4, 1, 2, 3 });
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void NumTimesAllBlue_4()
        {
            var solution = new _1375_BulbSwitcherIII();
            var result = solution.NumTimesAllBlue(new int[] { 2, 1, 4, 3, 6, 5 });
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void NumTimesAllBlue_5()
        {
            var solution = new _1375_BulbSwitcherIII();
            var result = solution.NumTimesAllBlue(new int[] { 1, 2, 3, 4, 5, 6 });
            Assert.AreEqual(6, result);
        }
    }
}
