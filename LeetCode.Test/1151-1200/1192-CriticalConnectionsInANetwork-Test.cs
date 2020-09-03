using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _1192_CriticalConnectionsInANetwork_Test
    {
        [TestMethod]
        public void CriticalConnections_1()
        {
            var solution = new _1192_CriticalConnectionsInANetwork();
            var result = solution.CriticalConnections(4, new List<IList<int>>() {
                new int[] { 0, 1 },
                new int[] { 1, 2 },
                new int[] { 2, 0 },
                new int[] { 1, 3 },
            });
            AssertHelper.AssertList(new List<IList<int>>() {
                new int[] { 1, 3 },
            }, result);
        }
    }
}
