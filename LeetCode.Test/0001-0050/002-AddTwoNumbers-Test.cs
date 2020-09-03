using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _002_AddTwoNumbers_Test
    {
        [TestMethod]
        public void AddTwoNumbersTest_General()
        {
            var link = TestHelper.GenerateList(new int[] { 2, 4, 3 });

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link, link);

            AssertHelper.AssertLinkList(new int[] { 4, 8, 6 }, result);
        }

        [TestMethod]
        public void AddTwoNumbersTest_General_2()
        {
            var link = TestHelper.GenerateList(new int[] { 0 });

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link, link);

            AssertHelper.AssertLinkList(new int[] { 0 }, result);
        }

        [TestMethod]
        public void AddTwoNumbersTest_HasCarry()
        {
            var link1 = TestHelper.GenerateList(new int[] { 2, 4, 3 });
            var link2 = TestHelper.GenerateList(new int[] { 5, 6, 4 });

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link1, link2);

            AssertHelper.AssertLinkList(new int[] { 7, 0, 8 }, result);
        }

        [TestMethod]
        public void AddTwoNumbersTest_HasMultipleCarry()
        {
            var link1 = TestHelper.GenerateList(new int[] { 1 });
            var link2 = TestHelper.GenerateList(new int[] { 9, 9 });

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link1, link2);

            AssertHelper.AssertLinkList(new int[] { 0, 0, 1 }, result);
        }

        [TestMethod]
        public void AddTwoNumbersTest_FirstNumCarry()
        {
            var link1 = TestHelper.GenerateList(new int[] { 3, 4, 4 });
            var link2 = TestHelper.GenerateList(new int[] { 3, 4, 6 });

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link1, link2);

            AssertHelper.AssertLinkList(new int[] { 6, 8, 0, 1 }, result);
        }

        [TestMethod]
        public void AddTwoNumbersTest_L1Longer()
        {
            var link1 = TestHelper.GenerateList(new int[] { 2, 4, 3, 1 });
            var link2 = TestHelper.GenerateList(new int[] { 5, 6, 4 });

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link1, link2);

            AssertHelper.AssertLinkList(new int[] { 7, 0, 8, 1 }, result);
        }

        [TestMethod]
        public void AddTwoNumbersTest_L1Longer_2()
        {
            var link1 = TestHelper.GenerateList(new int[] { 1, 8 });
            var link2 = TestHelper.GenerateList(new int[] { 0 });

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link1, link2);

            AssertHelper.AssertLinkList(new int[] { 1, 8 }, result);
        }

        [TestMethod]
        public void AddTwoNumbersTest_L1Empty()
        {
            var link1 = TestHelper.GenerateList(null);
            var link2 = TestHelper.GenerateList(new int[] { 1, 8 });

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link1, link2);

            AssertHelper.AssertLinkList(new int[] { 1, 8 }, result);
        }

        [TestMethod]
        public void AddTwoNumbersTest_L2Longer()
        {
            var link1 = TestHelper.GenerateList(new int[] { 2, 4, 3 });
            var link2 = TestHelper.GenerateList(new int[] { 5, 6, 4, 3 });

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link1, link2);

            AssertHelper.AssertLinkList(new int[] { 7, 0, 8, 3 }, result);
        }

        [TestMethod]
        public void AddTwoNumbersTest_L2Longer_2()
        {
            var link1 = TestHelper.GenerateList(new int[] { 0 });
            var link2 = TestHelper.GenerateList(new int[] { 1, 8 });

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link1, link2);

            AssertHelper.AssertLinkList(new int[] { 1, 8 }, result);
        }

        [TestMethod]
        public void AddTwoNumbersTest_L2Empty()
        {
            var link1 = TestHelper.GenerateList(new int[] { 1, 8 });
            var link2 = TestHelper.GenerateList(null);

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link1, link2);

            AssertHelper.AssertLinkList(new int[] { 1, 8 }, result);
        }
    }
}
