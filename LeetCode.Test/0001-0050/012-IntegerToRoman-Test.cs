using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _012_IntegerToRoman_Test
    {
        [TestMethod]
        public void IntToRomanTest_LessThan10()
        {
            var solution = new _012_IntegerToRoman();

            var result = solution.IntToRoman(1);
            Assert.AreEqual("I", result);

            result = solution.IntToRoman(4);
            Assert.AreEqual("IV", result);

            result = solution.IntToRoman(5);
            Assert.AreEqual("V", result);

            result = solution.IntToRoman(6);
            Assert.AreEqual("VI", result);

            result = solution.IntToRoman(9);
            Assert.AreEqual("IX", result);
        }

        [TestMethod]
        public void IntToRomanTest_LessThan100()
        {
            var solution = new _012_IntegerToRoman();

            var result = solution.IntToRoman(10);
            Assert.AreEqual("X", result);

            result = solution.IntToRoman(40);
            Assert.AreEqual("XL", result);

            result = solution.IntToRoman(50);
            Assert.AreEqual("L", result);

            result = solution.IntToRoman(74);
            Assert.AreEqual("LXXIV", result);

            result = solution.IntToRoman(90);
            Assert.AreEqual("XC", result);
        }

        [TestMethod]
        public void IntToRomanTest_LessThan1000()
        {
            var solution = new _012_IntegerToRoman();

            var result = solution.IntToRoman(100);
            Assert.AreEqual("C", result);

            result = solution.IntToRoman(400);
            Assert.AreEqual("CD", result);

            result = solution.IntToRoman(500);
            Assert.AreEqual("D", result);

            result = solution.IntToRoman(744);
            Assert.AreEqual("DCCXLIV", result);

            result = solution.IntToRoman(900);
            Assert.AreEqual("CM", result);
        }

        [TestMethod]
        public void IntToRomanTest_LessThan4000()
        {
            var solution = new _012_IntegerToRoman();

            var result = solution.IntToRoman(1000);
            Assert.AreEqual("M", result);

            result = solution.IntToRoman(2494);
            Assert.AreEqual("MMCDXCIV", result);
        }
    }
}
