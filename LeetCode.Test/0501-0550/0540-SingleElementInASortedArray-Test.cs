using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0540_SingleElementInASortedArray_Test
    {
        [TestMethod]
        public void SingleNonDuplicate_1()
        {
            var solution = new _0540_SingleElementInASortedArray();
            var result = solution.SingleNonDuplicate(new int[] { 1, 1, 2, 3, 3, 4, 4, 8, 8 });
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void SingleNonDuplicate_2()
        {
            var solution = new _0540_SingleElementInASortedArray();
            var result = solution.SingleNonDuplicate(new int[] { 3, 3, 7, 7, 10, 11, 11 });
            Assert.AreEqual(10, result);
        }
    }
}
