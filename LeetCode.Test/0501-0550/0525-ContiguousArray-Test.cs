using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0525_ContiguousArray_Test
    {
        [TestMethod]
        public void FindMaxLengthTest_1()
        {
            var solution = new _0525_ContiguousArray();
            var result = solution.FindMaxLength(new int[] { 0, 1 });
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void FindMaxLengthTest_2()
        {
            var solution = new _0525_ContiguousArray();
            var result = solution.FindMaxLength(new int[] { 0, 1, 0 });
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void FindMaxLengthTest_3()
        {
            var solution = new _0525_ContiguousArray();
            var result = solution.FindMaxLength(new int[] { 0, 0, 1, 0, 0, 0, 1, 1 });
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void FindMaxLengthTest_4()
        {
            var solution = new _0525_ContiguousArray();
            var result = solution.FindMaxLength(new int[] { 0, 1, 1, 0, 1, 1, 1, 0 });
            Assert.AreEqual(4, result);
        }
    }
}
