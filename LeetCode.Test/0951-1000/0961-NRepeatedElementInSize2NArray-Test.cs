using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0961_NRepeatedElementInSize2NArray_Test
    {
        [TestMethod]
        public void RepeatedNTimes_1()
        {
            var solution = new _0961_NRepeatedElementInSize2NArray();
            var result = solution.RepeatedNTimes(new int[] { 1, 2, 3, 3 });
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void RepeatedNTimes_2()
        {
            var solution = new _0961_NRepeatedElementInSize2NArray();
            var result = solution.RepeatedNTimes(new int[] { 2, 1, 2, 5, 3, 2 });
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void RepeatedNTimes_3()
        {
            var solution = new _0961_NRepeatedElementInSize2NArray();
            var result = solution.RepeatedNTimes(new int[] { 5, 1, 5, 2, 5, 3, 5, 4 });
            Assert.AreEqual(5, result);
        }
    }
}
