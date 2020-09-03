using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _027_RemoveElement_Test
    {
        [TestMethod]
        public void RemoveElementTest()
        {
            var input = new int[] { 1, 2, 3, 4, 5 };

            var solution = new _027_RemoveElement();
            var result = solution.RemoveElement(input, 3);

            Assert.AreEqual(4, result);
            AssertHelper.AssertArray(new int[] { 1, 2, 5, 4 }, input, true);
        }

        [TestMethod]
        public void RemoveElementTest_EmptyInput()
        {
            var solution = new _027_RemoveElement();
            var result = solution.RemoveElement(new int[] { }, 3);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void RemoveElementTest_OnlyOneItem_NotSame()
        {
            var input = new int[] { 1 };

            var solution = new _027_RemoveElement();
            var result = solution.RemoveElement(input, 3);

            Assert.AreEqual(1, result);
            AssertHelper.AssertArray(new int[] { 1 }, input);
        }

        [TestMethod]
        public void RemoveElementTest_OnlyOneItem_Same()
        {
            var input = new int[] { 1 };

            var solution = new _027_RemoveElement();
            var result = solution.RemoveElement(input, 1);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void RemoveElementTest_HaveMultipleValue()
        {
            var input = new int[] { 1, 2, 3, 3, 4, 5 };

            var solution = new _027_RemoveElement();
            var result = solution.RemoveElement(input, 3);

            Assert.AreEqual(4, result);
            AssertHelper.AssertArray(new int[] { 1, 2, 5, 4 }, input, true);
        }

        [TestMethod]
        public void RemoveElementTest_AllValue()
        {
            var input = new int[] { 3, 3, 3, 3, 3, 3 };

            var solution = new _027_RemoveElement();
            var result = solution.RemoveElement(input, 3);

            Assert.AreEqual(0, result);
        }
    }
}
