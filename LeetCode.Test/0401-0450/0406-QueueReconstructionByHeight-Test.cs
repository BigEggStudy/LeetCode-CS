using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0406_QueueReconstructionByHeight_Test
    {
        [TestMethod]
        public void ReconstructQueueTest()
        {
            var solution = new _0406_QueueReconstructionByHeight();
            var result = solution.ReconstructQueue(
                new int[][]
                {
                    new int[] { 7, 0 },
                    new int[] { 4, 4 },
                    new int[] { 7, 1 },
                    new int[] { 5, 0 },
                    new int[] { 6, 1 },
                    new int[] { 5, 2 },
                });
            AssertHelper.AssertArray(new int[][]
                {
                    new int[] { 5, 0 },
                    new int[] { 7, 0 },
                    new int[] { 5, 2 },
                    new int[] { 6, 1 },
                    new int[] { 4, 4 },
                    new int[] { 7, 1 },
                }, result);
        }
    }
}
