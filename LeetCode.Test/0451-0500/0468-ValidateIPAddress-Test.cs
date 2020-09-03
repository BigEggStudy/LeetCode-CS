using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0468_ValidateIPAddress_Test
    {
        [TestMethod]
        public void ValidIPAddress_1()
        {
            var solution = new _0468_ValidateIPAddress();
            var result = solution.ValidIPAddress("172.16.254.1");
            Assert.AreEqual("IPv4", result);
        }

        [TestMethod]
        public void ValidIPAddress_2()
        {
            var solution = new _0468_ValidateIPAddress();
            var result = solution.ValidIPAddress("2001:0db8:85a3:0:0:8A2E:0370:7334");
            Assert.AreEqual("IPv6", result);
        }

        [TestMethod]
        public void ValidIPAddress_3()
        {
            var solution = new _0468_ValidateIPAddress();
            var result = solution.ValidIPAddress("256.256.256.256");
            Assert.AreEqual("Neither", result);
        }
    }
}
