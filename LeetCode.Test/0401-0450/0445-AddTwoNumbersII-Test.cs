using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0445_AddTwoNumbersII_Test
    {
        [TestMethod]
        public void AddTwoNumbers_1()
        {
            var root1 = TestHelper.GenerateList(new int[] { 7, 2, 4, 3 });
            var root2 = TestHelper.GenerateList(new int[] { 5, 6, 4 });

            var solution = new _0445_AddTwoNumbersII();
            var result = solution.AddTwoNumbers(root1, root2);
            AssertHelper.AssertLinkList(new int[] { 7, 8, 0, 7 }, result);
        }

        [TestMethod]
        public void AddTwoNumbers_2()
        {
            var root1 = TestHelper.GenerateList(new int[] { 3, 9, 9, 9, 9, 9, 9, 9, 9, 9 });
            var root2 = TestHelper.GenerateList(new int[] { 7 });

            var solution = new _0445_AddTwoNumbersII();
            var result = solution.AddTwoNumbers(root1, root2);
            AssertHelper.AssertLinkList(new int[] { 4, 0, 0, 0, 0, 0, 0, 0, 0, 6 }, result);
        }

        [TestMethod]
        public void AddTwoNumbers_3()
        {
            var root1 = TestHelper.GenerateList(new int[] { 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 9 });
            var root2 = TestHelper.GenerateList(new int[] { 5, 6, 4, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 9, 9, 9, 9 });

            var solution = new _0445_AddTwoNumbersII();
            var result = solution.AddTwoNumbers(root1, root2);
            AssertHelper.AssertLinkList(new int[] { 8, 0, 7, 4, 8, 6, 4, 8, 6, 4, 8, 6, 4, 8, 6, 4, 8, 6, 4, 8, 6, 4, 8, 6, 4, 8, 6, 4, 8, 6, 4, 8, 6, 4, 8, 6, 4, 8, 6, 4, 8, 6, 4, 8, 6, 4, 8, 6, 4, 8, 6, 4, 8, 6, 4, 8, 7, 2, 4, 3, 8 }, result);
        }

        [TestMethod]
        public void AddTwoNumbers_4()
        {
            var root1 = TestHelper.GenerateList(new int[] { 0 });
            var root2 = TestHelper.GenerateList(new int[] { 0 });

            var solution = new _0445_AddTwoNumbersII();
            var result = solution.AddTwoNumbers(root1, root2);
            AssertHelper.AssertLinkList(new int[] { 0 }, result);
        }

        [TestMethod]
        public void AddTwoNumbers_5()
        {
            var root1 = TestHelper.GenerateList(new int[] { 5 });
            var root2 = TestHelper.GenerateList(new int[] { 5 });

            var solution = new _0445_AddTwoNumbersII();
            var result = solution.AddTwoNumbers(root1, root2);
            AssertHelper.AssertLinkList(new int[] { 1, 0 }, result);
        }

        [TestMethod]
        public void AddTwoNumbers_6()
        {
            var root1 = TestHelper.GenerateList(new int[] { 0 });
            var root2 = TestHelper.GenerateList(new int[] { 7, 3 });

            var solution = new _0445_AddTwoNumbersII();
            var result = solution.AddTwoNumbers(root1, root2);
            AssertHelper.AssertLinkList(new int[] { 7, 3 }, result);
        }
    }
}
