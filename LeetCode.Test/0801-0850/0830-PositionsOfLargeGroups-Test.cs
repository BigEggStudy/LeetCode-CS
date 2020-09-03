using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _0830_PositionsOfLargeGroups_Test
    {
        [TestMethod]
        public void LargeGroupPositions_1()
        {
            var solution = new _0830_PositionsOfLargeGroups();
            var result = solution.LargeGroupPositions("abbxxxxzzy");
            AssertHelper.AssertList(new List<IList<int>> {
                new int[] { 3, 6 },
            }, result);
        }

        [TestMethod]
        public void LargeGroupPositions_2()
        {
            var solution = new _0830_PositionsOfLargeGroups();
            var result = solution.LargeGroupPositions("abc");
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void LargeGroupPositions_3()
        {
            var solution = new _0830_PositionsOfLargeGroups();
            var result = solution.LargeGroupPositions("abcdddeeeeaabbbcd");
            AssertHelper.AssertList(new List<IList<int>> {
                new int[] { 3, 5 },
                new int[] { 6, 9 },
                new int[] { 12, 14 },
            }, result);
        }

        [TestMethod]
        public void LargeGroupPositions_4()
        {
            var solution = new _0830_PositionsOfLargeGroups();
            var result = solution.LargeGroupPositions("aaa");
            AssertHelper.AssertList(new List<IList<int>> {
                new int[] { 0, 2 },
            }, result);
        }
    }
}
