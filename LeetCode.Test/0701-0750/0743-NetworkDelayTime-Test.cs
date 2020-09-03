using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0743_NetworkDelayTime_Test
    {
        [TestMethod]
        public void NetworkDelayTimeTest()
        {
            var solution = new _0743_NetworkDelayTime();
            var result = solution.NetworkDelayTime(new int[][]
            {
                new int[] { 2, 1, 1 },
                new int[] { 2, 3, 1 },
                new int[] { 3, 4, 1 }
            }, 4, 2);
        }
    }
}
