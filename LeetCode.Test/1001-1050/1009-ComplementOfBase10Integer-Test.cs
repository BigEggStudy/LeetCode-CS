using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1009_ComplementOfBase10Integer_Test
    {
        [TestMethod]
        public void BitwiseComplement_1()
        {
            var solution = new _1009_ComplementOfBase10Integer();
            var result = solution.BitwiseComplement(5);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void BitwiseComplement_2()
        {
            var solution = new _1009_ComplementOfBase10Integer();
            var result = solution.BitwiseComplement(7);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void BitwiseComplement_3()
        {
            var solution = new _1009_ComplementOfBase10Integer();
            var result = solution.BitwiseComplement(10);
            Assert.AreEqual(5, result);
        }
    }
}
