using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0476_NumberComplement_Test
    {
        [TestMethod]
        public void FindComplement_1()
        {
            var solution = new _0476_NumberComplement();
            var result = solution.FindComplement(5);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void FindComplement_2()
        {
            var solution = new _0476_NumberComplement();
            var result = solution.FindComplement(1);
            Assert.AreEqual(0, result);
        }
    }
}
