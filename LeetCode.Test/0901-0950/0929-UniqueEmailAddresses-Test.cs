using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0929_UniqueEmailAddresses_Test
    {
        [TestMethod]
        public void NumUniqueEmailsTest()
        {
            var solution = new _0929_UniqueEmailAddresses();
            var result = solution.NumUniqueEmails(new string[] { "test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com" });
            Assert.AreEqual(2, result);
        }
    }
}
