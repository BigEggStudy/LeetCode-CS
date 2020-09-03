using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0989_AddToArrayFormOfInteger_Test
    {
        [TestMethod]
        public void AddToArrayForm_1()
        {
            var solution = new _0989_AddToArrayFormOfInteger();
            var result = solution.AddToArrayForm(new int[] { 1, 2, 0, 0 }, 34);
            AssertHelper.AssertList(new int[] { 1, 2, 3, 4 }, result);
        }

        [TestMethod]
        public void AddToArrayForm_2()
        {
            var solution = new _0989_AddToArrayFormOfInteger();
            var result = solution.AddToArrayForm(new int[] { 2, 7, 4 }, 181);
            AssertHelper.AssertList(new int[] { 4, 5, 5 }, result);
        }

        [TestMethod]
        public void AddToArrayForm_3()
        {
            var solution = new _0989_AddToArrayFormOfInteger();
            var result = solution.AddToArrayForm(new int[] { 2, 1, 5 }, 806);
            AssertHelper.AssertList(new int[] { 1, 0, 2, 1 }, result);
        }

        [TestMethod]
        public void AddToArrayForm_4()
        {
            var solution = new _0989_AddToArrayFormOfInteger();
            var result = solution.AddToArrayForm(new int[] { 9, 9, 9, 9, 9, 9, 9, 9, 9, 9 }, 1);
            AssertHelper.AssertList(new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, result);
        }
    }
}
