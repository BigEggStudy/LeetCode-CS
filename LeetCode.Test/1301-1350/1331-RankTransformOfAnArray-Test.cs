using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1331_RankTransformOfAnArray_Test
    {
        [TestMethod]
        public void ArrayRankTransform_1()
        {
            var solution = new _1331_RankTransformOfAnArray();
            var result = solution.ArrayRankTransform(new int[] { 40, 10, 20, 30 });
            AssertHelper.AssertArray(new int[] { 4, 1, 2, 3 }, result);
        }

        [TestMethod]
        public void ArrayRankTransform_2()
        {
            var solution = new _1331_RankTransformOfAnArray();
            var result = solution.ArrayRankTransform(new int[] { 100, 100, 100 });
            AssertHelper.AssertArray(new int[] { 1, 1, 1 }, result);
        }

        [TestMethod]
        public void ArrayRankTransform_3()
        {
            var solution = new _1331_RankTransformOfAnArray();
            var result = solution.ArrayRankTransform(new int[] { 37, 12, 28, 9, 100, 56, 80, 5, 12 });
            AssertHelper.AssertArray(new int[] { 5, 3, 4, 2, 8, 6, 7, 1, 3 }, result);
        }
    }
}
