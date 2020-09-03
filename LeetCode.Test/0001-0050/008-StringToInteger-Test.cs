using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _008_StringToInteger_Test
    {
        [TestMethod]
        public void MyAtoiTest_Positive()
        {
            var solution = new _008_StringToInteger();

            var result = solution.MyAtoi("123");
            Assert.AreEqual(123, result);

            result = solution.MyAtoi("+123");
            Assert.AreEqual(123, result);
        }

        [TestMethod]
        public void MyAtoiTest_Nagative()
        {
            var solution = new _008_StringToInteger();

            var result = solution.MyAtoi("-123");
            Assert.AreEqual(-123, result);
        }

        [TestMethod]
        public void MyAtoiTest_Zero()
        {
            var solution = new _008_StringToInteger();

            var result = solution.MyAtoi("0");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void MyAtoiTest_PositiveZero()
        {
            var solution = new _008_StringToInteger();

            var result = solution.MyAtoi("+0");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void MyAtoiTest_NagativeZero()
        {
            var solution = new _008_StringToInteger();

            var result = solution.MyAtoi("-0");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void MyAtoiTest_Boundary()
        {
            var solution = new _008_StringToInteger();

            var result = solution.MyAtoi("2147483647");
            Assert.AreEqual(2147483647, result);

            result = solution.MyAtoi("2147483646");
            Assert.AreEqual(2147483646, result);

            result = solution.MyAtoi("-2147483648");
            Assert.AreEqual(-2147483648, result);

            result = solution.MyAtoi("-2147483647");
            Assert.AreEqual(-2147483647, result);
        }

        [TestMethod]
        public void MyAtoiTest_PositiveOverflow()
        {
            var solution = new _008_StringToInteger();

            var result = solution.MyAtoi("2147483648");
            Assert.AreEqual(int.MaxValue, result);

            result = solution.MyAtoi("2247483647");
            Assert.AreEqual(int.MaxValue, result);
        }

        [TestMethod]
        public void MyAtoiTest_NagativeOverflow()
        {
            var solution = new _008_StringToInteger();

            var result = solution.MyAtoi("-2147483649");
            Assert.AreEqual(int.MinValue, result);

            result = solution.MyAtoi("-2247483648");
            Assert.AreEqual(int.MinValue, result);
        }

        [TestMethod]
        public void MyAtoiTest_WhiteSpaceInFrontOfInput()
        {
            var solution = new _008_StringToInteger();

            var result = solution.MyAtoi("   123");
            Assert.AreEqual(123, result);

            result = solution.MyAtoi("   -123");
            Assert.AreEqual(-123, result);
        }

        [TestMethod]
        public void MyAtoiTest_EmptyString()
        {
            var solution = new _008_StringToInteger();

            var result = solution.MyAtoi("");
            Assert.AreEqual(0, result);

            result = solution.MyAtoi("   ");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void MyAtoiTest_InvalidInput()
        {
            var solution = new _008_StringToInteger();

            var result = solution.MyAtoi("abc");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void MyAtoiTest_MixInput()
        {
            var solution = new _008_StringToInteger();

            var result = solution.MyAtoi("123abc");
            Assert.AreEqual(123, result);

            result = solution.MyAtoi("-123abc");
            Assert.AreEqual(-123, result);
        }

        [TestMethod]
        public void MyAtoiTest_MixInputWithOverflow()
        {
            var solution = new _008_StringToInteger();

            var result = solution.MyAtoi("  2147483648abc");
            Assert.AreEqual(int.MaxValue, result);

            result = solution.MyAtoi("  2247483647abc");
            Assert.AreEqual(int.MaxValue, result);

            result = solution.MyAtoi("  -2147483649abc");
            Assert.AreEqual(int.MinValue, result);

            result = solution.MyAtoi("  -2247483648abc");
            Assert.AreEqual(int.MinValue, result);
        }
    }
}
