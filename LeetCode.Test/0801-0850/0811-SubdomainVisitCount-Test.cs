using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0811_SubdomainVisitCount_Test
    {
        [TestMethod]
        public void SubdomainVisits_1()
        {
            var solution = new _0811_SubdomainVisitCount();
            var result = solution.SubdomainVisits(new string[] { "9001 discuss.leetcode.com" });
            AssertHelper.AssertList(new string[] { "9001 com", "9001 leetcode.com", "9001 discuss.leetcode.com" }, result);
        }

        [TestMethod]
        public void SubdomainVisits_2()
        {
            var solution = new _0811_SubdomainVisitCount();
            var result = solution.SubdomainVisits(new string[] { "900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org" });
            AssertHelper.AssertList(new string[] { "951 com", "901 mail.com", "900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 org", "5 wiki.org" }, result);
        }
    }
}
