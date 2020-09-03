using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0661_ImageSmoother_Test
    {
        [TestMethod]
        public void ImageSmoother_1()
        {
            var solution = new _0661_ImageSmoother();
            var result = solution.ImageSmoother(new int[][]
                {
                    new int[] { 1, 1, 1 },
                    new int[] { 1, 0, 1 },
                    new int[] { 1, 1, 1 },
                });
            AssertHelper.AssertArray(
                new int[][]
                {
                    new int[] { 0, 0, 0 },
                    new int[] { 0, 0, 0 },
                    new int[] { 0, 0, 0 },
                }, result);
        }
    }
}
