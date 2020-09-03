using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _061_RotateList_Test
    {
        [TestMethod]
        public void RotateRightTest()
        {
            var input = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _061_RotateList();
            var result = solution.RotateRight(input, 3);

            AssertHelper.AssertLinkList(new int[] { 3, 4, 5, 1, 2 }, result);
        }

        [TestMethod]
        public void RotateRightTest_EmptyInput()
        {
            var solution = new _061_RotateList();
            var result = solution.RotateRight(null, 3);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void RotateRightTest_KLessThanZero()
        {
            var input = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _061_RotateList();
            var result = solution.RotateRight(input, -1);

            AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 4, 5 }, result);
        }

        [TestMethod]
        public void RotateRightTest_KEqualZero()
        {
            var input = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _061_RotateList();
            var result = solution.RotateRight(input, 0);

            AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 4, 5 }, result);
        }

        [TestMethod]
        public void RotateRightTest_KLargerThanLenght()
        {
            var input = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _061_RotateList();
            var result = solution.RotateRight(input, 6);

            AssertHelper.AssertLinkList(new int[] { 5, 1, 2, 3, 4 }, result);
        }

        [TestMethod]
        public void RotateRightTest_KEqualToLenght()
        {
            var input = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _061_RotateList();
            var result = solution.RotateRight(input, 5);

            AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 4, 5 }, result);
        }

        [TestMethod]
        public void RotateRightTest_OneItem()
        {
            var input = TestHelper.GenerateList(new int[] { 1 });

            var solution = new _061_RotateList();
            var result = solution.RotateRight(input, 5);

            AssertHelper.AssertLinkList(new int[] { 1 }, result);
        }

        [TestMethod]
        [Timeout(100)]
        public void RotateRightTest_LargeK()
        {
            var input = TestHelper.GenerateList(new int[] { 1, 2, 3 });

            var solution = new _061_RotateList();
            var result = solution.RotateRight(input, 2000000000);

            AssertHelper.AssertLinkList(new int[] { 2, 3, 1 }, result);
        }
    }
}
