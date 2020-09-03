using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _0721_AccountsMerge_Test
    {
        [TestMethod]
        public void AccountsMerge_1()
        {
            var solution = new _0721_AccountsMerge();
            var result = solution.AccountsMerge(new List<IList<string>>() {
                new string[] { "John", "johnsmith@mail.com", "john00@mail.com" },
                new string[] { "John", "johnnybravo@mail.com" },
                new string[] { "John", "johnsmith@mail.com", "john_newyork@mail.com" },
                new string[] { "Mary", "mary@mail.com" },
            });
            AssertHelper.AssertList(new List<IList<string>>()
            {
                new string[] { "John", "john00@mail.com", "john_newyork@mail.com", "johnsmith@mail.com" },
                new string[] { "John", "johnnybravo@mail.com" },
                new string[] { "Mary", "mary@mail.com" },
            }, result);
        }
    }
}
