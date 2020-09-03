using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1394_FindLuckyIntegerInAnArray_Test
    {
        [TestMethod]
        public void FindLucky_1()
        {
            var solution = new _1394_FindLuckyIntegerInAnArray();
            var result = solution.FindLucky(new int[] { 2, 2, 3, 4 });
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void FindLucky_2()
        {
            var solution = new _1394_FindLuckyIntegerInAnArray();
            var result = solution.FindLucky(new int[] { 1, 2, 2, 3, 3, 3 });
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void FindLucky_3()
        {
            var solution = new _1394_FindLuckyIntegerInAnArray();
            var result = solution.FindLucky(new int[] { 2, 2, 2, 3, 3 });
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void FindLucky_4()
        {
            var solution = new _1394_FindLuckyIntegerInAnArray();
            var result = solution.FindLucky(new int[] { 5 });
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void FindLucky_5()
        {
            var solution = new _1394_FindLuckyIntegerInAnArray();
            var result = solution.FindLucky(new int[] { 7, 7, 7, 7, 7, 7, 7 });
            Assert.AreEqual(7, result);
        }
    }
}
