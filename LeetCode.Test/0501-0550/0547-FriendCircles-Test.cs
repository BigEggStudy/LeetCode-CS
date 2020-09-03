using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0547_FriendCircles_Test
    {
        [TestMethod]
        public void FindCircleNum_1()
        {
            var solution = new _0547_FriendCircles();
            var result = solution.FindCircleNum(new int[][] {
                new int[] { 1, 1, 0 },
                new int[] { 1, 1, 0 },
                new int[] { 0, 0, 1 },
            });
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void FindCircleNum_2()
        {
            var solution = new _0547_FriendCircles();
            var result = solution.FindCircleNum(new int[][] {
                new int[] { 1, 1, 0 },
                new int[] { 1, 1, 1 },
                new int[] { 0, 1, 1 },
            });
            Assert.AreEqual(1, result);
        }
    }
}
