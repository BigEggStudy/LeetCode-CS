using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1338_ReduceArraySizeToTheHalf_Test
    {
        [TestMethod]
        public void MinSetSize_1()
        {
            var solution = new _1338_ReduceArraySizeToTheHalf();
            var result = solution.MinSetSize(new int[] { 3, 3, 3, 3, 5, 5, 5, 2, 2, 7 });
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void MinSetSize_2()
        {
            var solution = new _1338_ReduceArraySizeToTheHalf();
            var result = solution.MinSetSize(new int[] { 7, 7, 7, 7, 7, 7 });
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void MinSetSize_3()
        {
            var solution = new _1338_ReduceArraySizeToTheHalf();
            var result = solution.MinSetSize(new int[] { 1, 9 });
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void MinSetSize_4()
        {
            var solution = new _1338_ReduceArraySizeToTheHalf();
            var result = solution.MinSetSize(new int[] { 1000, 1000, 3, 7 });
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void MinSetSize_5()
        {
            var solution = new _1338_ReduceArraySizeToTheHalf();
            var result = solution.MinSetSize(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            Assert.AreEqual(5, result);
        }
    }
}
