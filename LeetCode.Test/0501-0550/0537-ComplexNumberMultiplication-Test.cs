using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0537_ComplexNumberMultiplication_Test
    {
        [TestMethod]
        public void ComplexNumberMultiply_1()
        {
            var solution = new _0537_ComplexNumberMultiplication();
            var result = solution.ComplexNumberMultiply("1+1i", "1+1i");
            Assert.AreEqual("0+2i", result);
        }

        [TestMethod]
        public void ComplexNumberMultiply_2()
        {
            var solution = new _0537_ComplexNumberMultiplication();
            var result = solution.ComplexNumberMultiply("1+-1i", "1+-1i");
            Assert.AreEqual("0+-2i", result);
        }
    }
}
