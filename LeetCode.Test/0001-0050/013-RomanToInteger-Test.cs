using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _013_RomanToInteger_Test
    {
        [TestMethod]
        public void RomanToIntTest_LessThan10()
        {
            var solution = new _013_RomanToInteger();

            var result = solution.RomanToInt("I");
            Assert.AreEqual(1, result);

            result = solution.RomanToInt("IV");
            Assert.AreEqual(4, result);

            result = solution.RomanToInt("V");
            Assert.AreEqual(5, result);

            result = solution.RomanToInt("VI");
            Assert.AreEqual(6, result);

            result = solution.RomanToInt("IX");
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void RomanToIntTest_LessThan100()
        {
            var solution = new _013_RomanToInteger();

            var result = solution.RomanToInt("X");
            Assert.AreEqual(10, result);

            result = solution.RomanToInt("XL");
            Assert.AreEqual(40, result);

            result = solution.RomanToInt("L");
            Assert.AreEqual(50, result);

            result = solution.RomanToInt("LXXIV");
            Assert.AreEqual(74, result);

            result = solution.RomanToInt("XC");
            Assert.AreEqual(90, result);
        }

        [TestMethod]
        public void RomanToIntTest_LessThan1000()
        {
            var solution = new _013_RomanToInteger();

            var result = solution.RomanToInt("C");
            Assert.AreEqual(100, result);

            result = solution.RomanToInt("CD");
            Assert.AreEqual(400, result);

            result = solution.RomanToInt("D");
            Assert.AreEqual(500, result);

            result = solution.RomanToInt("DCCXLIV");
            Assert.AreEqual(744, result);

            result = solution.RomanToInt("CM");
            Assert.AreEqual(900, result);
        }

        [TestMethod]
        public void RomanToIntTest_LessThan4000()
        {
            var solution = new _013_RomanToInteger();

            var result = solution.RomanToInt("M");
            Assert.AreEqual(1000, result);

            result = solution.RomanToInt("MMCDXCIV");
            Assert.AreEqual(2494, result);
        }
    }
}
