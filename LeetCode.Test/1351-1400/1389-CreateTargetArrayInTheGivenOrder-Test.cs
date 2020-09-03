using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1389_CreateTargetArrayInTheGivenOrder_Test
    {
        [TestMethod]
        public void CreateTargetArray_1()
        {
            var solution = new _1389_CreateTargetArrayInTheGivenOrder();
            var result = solution.CreateTargetArray(new int[] { 0, 1, 2, 3, 4 }, new int[] { 0, 1, 2, 2, 1 });
            AssertHelper.AssertArray(new int[] { 0, 4, 1, 3, 2 }, result);
        }

        [TestMethod]
        public void CreateTargetArray_2()
        {
            var solution = new _1389_CreateTargetArrayInTheGivenOrder();
            var result = solution.CreateTargetArray(new int[] { 1, 2, 3, 4, 0 }, new int[] { 0, 1, 2, 3, 0 });
            AssertHelper.AssertArray(new int[] { 0, 1, 2, 3, 4 }, result);
        }

        [TestMethod]
        public void CreateTargetArray_3()
        {
            var solution = new _1389_CreateTargetArrayInTheGivenOrder();
            var result = solution.CreateTargetArray(new int[] { 1 }, new int[] { 0 });
            AssertHelper.AssertArray(new int[] { 1 }, result);
        }
    }
}
