using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _093_RestoreIPAddresses_Test
    {
        [TestMethod]
        public void RestoreIpAddressesTest()
        {
            var solution = new _093_RestoreIPAddresses();
            var result = solution.RestoreIpAddresses("25525511135");
            AssertHelper.AssertList(new string[] { "255.255.11.135", "255.255.111.35" }, result);
            result = solution.RestoreIpAddresses("255255135");
            AssertHelper.AssertList(new string[] { "2.55.255.135", "25.5.255.135", "25.52.55.135", "255.2.55.135", "255.25.5.135", "255.25.51.35", "255.255.1.35", "255.255.13.5" }, result);
        }

        [TestMethod]
        public void RestoreIpAddressesTest_NotEnough()
        {
            var solution = new _093_RestoreIPAddresses();
            var result = solution.RestoreIpAddresses("111");
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void RestoreIpAddressesTest_TooLong()
        {
            var solution = new _093_RestoreIPAddresses();
            var result = solution.RestoreIpAddresses("1111111111111");
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void RestoreIpAddressesTest_WithZero_NotValid()
        {
            var solution = new _093_RestoreIPAddresses();
            var result = solution.RestoreIpAddresses("25525500135");
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void RestoreIpAddressesTest_WithZero()
        {
            var solution = new _093_RestoreIPAddresses();
            var result = solution.RestoreIpAddresses("2552550135");
            AssertHelper.AssertList(new string[] { "255.25.50.135", "255.255.0.135" }, result);
        }

        [TestMethod]
        public void RestoreIpAddressesTest_AllZero()
        {
            var solution = new _093_RestoreIPAddresses();
            var result = solution.RestoreIpAddresses("0000");
            AssertHelper.AssertList(new string[] { "0.0.0.0" }, result);
        }

        [TestMethod]
        public void RestoreIpAddressesTest_AllZero_NotValid()
        {
            var solution = new _093_RestoreIPAddresses();
            var result = solution.RestoreIpAddresses("00000");
            Assert.AreEqual(0, result.Count);
            result = solution.RestoreIpAddresses("000");
            Assert.AreEqual(0, result.Count);
        }
    }
}
