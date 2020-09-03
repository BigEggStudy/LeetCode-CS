using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _0131_PalindromePartitioning_Test
    {
        [TestMethod]
        public void PartitionTest()
        {
            var solution = new _0131_PalindromePartitioning();
            var result = solution.Partition("aab");
            AssertHelper.AssertList(new List<IList<string>>()
            {
                new List<string>() { "a", "a", "b" },
                new List<string>() { "aa", "b" },
            }, result);
        }
    }
}
