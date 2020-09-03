using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1387_SortIntegersByThePowerValue_Test
    {
        [TestMethod]
        public void GetKth_1()
        {
            var solution = new _1387_SortIntegersByThePowerValue();
            var result = solution.GetKth(12, 15, 2);
            Assert.AreEqual(13, result);
        }

        [TestMethod]
        public void GetKth_2()
        {
            var solution = new _1387_SortIntegersByThePowerValue();
            var result = solution.GetKth(1, 1, 1);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GetKth_3()
        {
            var solution = new _1387_SortIntegersByThePowerValue();
            var result = solution.GetKth(7, 11, 4);
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void GetKth_4()
        {
            var solution = new _1387_SortIntegersByThePowerValue();
            var result = solution.GetKth(10, 20, 5);
            Assert.AreEqual(13, result);
        }

        [TestMethod]
        public void GetKth_5()
        {
            var solution = new _1387_SortIntegersByThePowerValue();
            var result = solution.GetKth(1, 1000, 777);
            Assert.AreEqual(570, result);
        }
    }
}
