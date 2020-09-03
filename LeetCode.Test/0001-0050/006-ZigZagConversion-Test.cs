using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _006_ZigZagConversion_Test
    {
        [TestMethod]
        public void ConvertTest_General()
        {
            var input = "PAYPALISHIRING";

            var solution = new _006_ZigZagConversion();

            var result = solution.Convert(input, 3);
            Assert.AreEqual("PAHNAPLSIIGYIR", result);

            result = solution.Convert(input, 4);
            Assert.AreEqual("PINALSIGYAHRPI", result);

            result = solution.Convert(input, 5);
            Assert.AreEqual("PHASIYIRPLIGAN", result);
        }

        [TestMethod]
        public void ConvertTest_RowNumberEqualOne()
        {
            var input = "PAYPALISHIRING";

            var solution = new _006_ZigZagConversion();

            var result = solution.Convert(input, 1);
            Assert.AreEqual(input, result);
        }

        [TestMethod]
        public void ConvertTest_RowNumberEqualZero()
        {
            var input = "PAYPALISHIRING";

            var solution = new _006_ZigZagConversion();

            var result = solution.Convert(input, 0);
            Assert.AreEqual(input, result);
        }

        [TestMethod]
        public void ConvertTest_EmptyString()
        {
            var input = string.Empty;

            var solution = new _006_ZigZagConversion();

            var result = solution.Convert(input, 0);
            Assert.AreEqual(input, result);
        }
    }
}
