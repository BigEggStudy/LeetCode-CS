using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _0218_TheSkylineProblem_Test
    {
        [TestMethod]
        public void GetSkylineTest()
        {
            var buildings = new int[][]
            {
                new int[] { 2, 9, 10, },
                new int[] { 3, 7, 15, },
                new int[] { 5, 12, 12, },
                new int[] { 15, 20, 10, },
                new int[] { 19, 24, 8, }
            };

            var solution = new _0218_TheSkylineProblem();
            var result = solution.GetSkyline(buildings);
            AssertHelper.AssertList(new List<IList<int>>
            {
                new List<int> { 2, 10 },
                new List<int> { 3, 15 },
                new List<int> { 7, 12 },
                new List<int> { 12, 0 },
                new List<int> { 15, 10 },
                new List<int> { 20, 8 },
                new List<int> { 24, 0 }
            }, result);
        }

        [TestMethod]
        public void GetSkylineTest_2()
        {
            var buildings = new int[][]
            {
                new int[] { 0, 2, 3, },
                new int[] { 2, 5, 3, },
            };

            var solution = new _0218_TheSkylineProblem();
            var result = solution.GetSkyline(buildings);
            AssertHelper.AssertList(new List<IList<int>>
            {
                new List<int> { 0, 3 },
                new List<int> { 5, 0 }
            }, result);
        }

        [TestMethod]
        public void GetSkylineTest_3()
        {
            var buildings = new int[][]
            {
                new int[] { 0, 2, 3, },
                new int[] { 2, 5, 3, },
                new int[] { 2, 7, 3, },
            };

            var solution = new _0218_TheSkylineProblem();
            var result = solution.GetSkyline(buildings);
            AssertHelper.AssertList(new List<IList<int>>
            {
                new List<int> { 0, 3 },
                new List<int> { 7, 0 }
            }, result);
        }
    }
}
