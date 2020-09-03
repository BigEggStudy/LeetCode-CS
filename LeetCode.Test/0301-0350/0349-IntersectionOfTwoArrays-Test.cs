using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0349_IntersectionOfTwoArrays_Test
    {
        [TestMethod]
        public void IntersectionTest_1()
        {
            var solution = new _0349_IntersectionOfTwoArrays();
            var result = solution.Intersection(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 });
            AssertHelper.AssertArray(new int[] { 2 }, result);
        }

        [TestMethod]
        public void IntersectionTest_2()
        {
            var solution = new _0349_IntersectionOfTwoArrays();
            var result = solution.Intersection(new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 });
            AssertHelper.AssertArray(new int[] { 4, 9 }, result);
        }
    }
}
