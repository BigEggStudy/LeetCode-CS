using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _1200_MinimumAbsoluteDifference_Test
    {
        [TestMethod]
        public void MinimumAbsDifference_1()
        {
            var solution = new _1200_MinimumAbsoluteDifference();
            var result = solution.MinimumAbsDifference(new int[] { 4, 2, 1, 3 });
            AssertHelper.AssertList(new List<IList<int>>() {
                new int[] { 1, 2 },
                new int[] { 2, 3 },
                new int[] { 3, 4 },
            }, result);
        }

        [TestMethod]
        public void MinimumAbsDifference_2()
        {
            var solution = new _1200_MinimumAbsoluteDifference();
            var result = solution.MinimumAbsDifference(new int[] { 1, 3, 6, 10, 15 });
            AssertHelper.AssertList(new List<IList<int>>() {
                new int[] { 1, 3 },
            }, result);
        }

        [TestMethod]
        public void MinimumAbsDifference_3()
        {
            var solution = new _1200_MinimumAbsoluteDifference();
            var result = solution.MinimumAbsDifference(new int[] { 3, 8, -10, 23, 19, -4, -14, 27 });
            AssertHelper.AssertList(new List<IList<int>>() {
                new int[] { -14, -10 },
                new int[] { 19, 23 },
                new int[] { 23, 27 },
            }, result);
        }
    }
}
