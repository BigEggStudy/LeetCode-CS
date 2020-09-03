using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0227_BasicCalculatorII_Test
    {
        [TestMethod]
        public void Calculate_1()
        {
            var solution = new _0227_BasicCalculatorII();
            var result = solution.Calculate("3+2*2");
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void Calculate_2()
        {
            var solution = new _0227_BasicCalculatorII();
            var result = solution.Calculate(" 3/2 ");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Calculate_3()
        {
            var solution = new _0227_BasicCalculatorII();
            var result = solution.Calculate(" 3+5 / 2 ");
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Calculate_4()
        {
            var solution = new _0227_BasicCalculatorII();
            var result = solution.Calculate("1-1+1");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Calculate_5()
        {
            var solution = new _0227_BasicCalculatorII();
            var result = solution.Calculate("0-2147483647");
            Assert.AreEqual(-2147483647, result);
        }

        [TestMethod]
        public void Calculate_6()
        {
            var solution = new _0227_BasicCalculatorII();
            var result = solution.Calculate("2*3-4");
            Assert.AreEqual(2, result);
        }
    }
}
