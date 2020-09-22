using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _0216_CombinationSumIII_Test
    {
        [TestMethod]
        public void CombinationSum3_1()
        {
            var solution = new _0216_CombinationSumIII();
            var result = solution.CombinationSum3(3, 7);
            AssertHelper.AssertList(new List<IList<int>>()
            {
                new int[] { 1, 2, 4},
            }, result);
        }

        [TestMethod]
        public void CombinationSum3_2()
        {
            var solution = new _0216_CombinationSumIII();
            var result = solution.CombinationSum3(3, 9);
            AssertHelper.AssertList(new List<IList<int>>()
            {
                new int[] { 1, 2, 6 },
                new int[] { 1, 3, 5 },
                new int[] { 2, 3, 4 },
            }, result);
        }

        [TestMethod]
        public void CombinationSum3_3()
        {
            var solution = new _0216_CombinationSumIII();
            var result = solution.CombinationSum3(4, 1);
            AssertHelper.AssertList(new List<IList<int>>()
            {
            }, result);
        }

        [TestMethod]
        public void CombinationSum3_4()
        {
            var solution = new _0216_CombinationSumIII();
            var result = solution.CombinationSum3(3, 2);
            AssertHelper.AssertList(new List<IList<int>>()
            {
            }, result);
        }

        [TestMethod]
        public void CombinationSum3_5()
        {
            var solution = new _0216_CombinationSumIII();
            var result = solution.CombinationSum3(9, 45);
            AssertHelper.AssertList(new List<IList<int>>()
            {
                new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            }, result);
        }
    }
}
