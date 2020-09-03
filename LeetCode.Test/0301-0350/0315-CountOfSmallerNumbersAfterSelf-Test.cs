using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LeetCode.Test
{
    [TestClass]
    public class _0315_CountOfSmallerNumbersAfterSelf_Test
    {
        [TestMethod]
        public void CountSmallerTest()
        {
            var solution = new _0315_CountOfSmallerNumbersAfterSelf();
            var result = solution.CountSmaller(new int[] { 5, 2, 6, 1 });
            AssertHelper.AssertList(new int[] { 2, 1, 1, 0 }, result);
        }

        [TestMethod]
        public void CountSmallerTest_Duplicate()
        {
            var solution = new _0315_CountOfSmallerNumbersAfterSelf();
            var result = solution.CountSmaller(new int[] { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 });
            AssertHelper.AssertList(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, result);
        }

        [TestMethod]
        public void CountSmallerTest_Empty()
        {
            var solution = new _0315_CountOfSmallerNumbersAfterSelf();
            var result = solution.CountSmaller(new int[] { });
            AssertHelper.AssertList(new int[] { }, result);
        }

        [TestMethod]
        [Timeout(2000)]
        public void CountSmallerTest_LongList()
        {
            var random = new Random();
            var input = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                input[i] = random.Next(-10000, 10000);
            }

            var solution = new _0315_CountOfSmallerNumbersAfterSelf();
            var result = solution.CountSmaller(input);
        }
    }
}
