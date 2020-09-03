using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0772_BasicCalculatorIII_Test
    {
        [TestMethod]
        public void Calculate_1()
        {
            var solution = new _0772_BasicCalculatorIII();
            var result = solution.Calculate("1 + 1");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Calculate_2()
        {
            var solution = new _0772_BasicCalculatorIII();
            var result = solution.Calculate(" 6-4 / 2 ");
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Calculate_3()
        {
            var solution = new _0772_BasicCalculatorIII();
            var result = solution.Calculate("2 * (5 + 5 * 2) / 3 + (6 / 2 + 8)");
            Assert.AreEqual(21, result);
        }

        [TestMethod]
        public void Calculate_4()
        {
            var solution = new _0772_BasicCalculatorIII();
            var result = solution.Calculate("(2+6* 3+5- (3*14/7+2)*5)+3");
            Assert.AreEqual(-12, result);
        }

        [TestMethod]
        public void Calculate_5()
        {
            var solution = new _0772_BasicCalculatorIII();
            var result = solution.Calculate("5 - 3/2");
            Assert.AreEqual(4, result);
        }
    }
}
