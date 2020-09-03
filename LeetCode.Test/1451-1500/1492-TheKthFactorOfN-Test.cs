using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1492_TheKthFactorOfN_Test
    {
        [TestMethod]
        public void KthFactor_1()
        {
            var solution = new _1492_TheKthFactorOfN();
            var result = solution.KthFactor(12, 3);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void KthFactor_2()
        {
            var solution = new _1492_TheKthFactorOfN();
            var result = solution.KthFactor(7, 2);
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void KthFactor_3()
        {
            var solution = new _1492_TheKthFactorOfN();
            var result = solution.KthFactor(4, 4);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void KthFactor_4()
        {
            var solution = new _1492_TheKthFactorOfN();
            var result = solution.KthFactor(1, 1);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void KthFactor_5()
        {
            var solution = new _1492_TheKthFactorOfN();
            var result = solution.KthFactor(1000, 3);
            Assert.AreEqual(4, result);
        }
    }
}
