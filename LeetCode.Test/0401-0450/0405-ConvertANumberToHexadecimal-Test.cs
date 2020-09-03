using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0405_ConvertANumberToHexadecimal_Test
    {
        [TestMethod]
        public void ToHex_1()
        {
            var solution = new _0405_ConvertANumberToHexadecimal();
            var result = solution.ToHex(26);
            Assert.AreEqual("1a", result);
        }

        [TestMethod]
        public void ToHex_2()
        {
            var solution = new _0405_ConvertANumberToHexadecimal();
            var result = solution.ToHex(-1);
            Assert.AreEqual("ffffffff", result);
        }

        [TestMethod]
        public void ToHex_3()
        {
            var solution = new _0405_ConvertANumberToHexadecimal();
            var result = solution.ToHex(0);
            Assert.AreEqual("0", result);
        }
    }
}
