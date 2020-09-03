using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1024_VideoStitching_Test
    {
        [TestMethod]
        public void VideoStitching_1()
        {
            var solution = new _1024_VideoStitching();
            var result = solution.VideoStitching(new int[][] {
                new int[] { 0, 2 },
                new int[] { 4, 6 },
                new int[] { 8, 10 },
                new int[] { 1, 9 },
                new int[] { 1, 5 },
                new int[] { 5, 9 },
            }, 10);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void VideoStitching_2()
        {
            var solution = new _1024_VideoStitching();
            var result = solution.VideoStitching(new int[][] {
                new int[] { 0, 1 },
                new int[] { 1, 2 },
            }, 5);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void VideoStitching_3()
        {
            var solution = new _1024_VideoStitching();
            var result = solution.VideoStitching(new int[][] {
                new int[] { 0, 1 },
                new int[] { 6, 8 },
                new int[] { 0, 2 },
                new int[] { 5, 6 },
                new int[] { 0, 4 },
                new int[] { 0, 3 },
                new int[] { 6, 7 },
                new int[] { 1, 3 },
                new int[] { 4, 7 },
                new int[] { 1, 4 },
                new int[] { 2, 5 },
                new int[] { 2, 6 },
                new int[] { 3, 4 },
                new int[] { 4, 5 },
                new int[] { 5, 7 },
                new int[] { 6, 9 },
            }, 9);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void VideoStitching_4()
        {
            var solution = new _1024_VideoStitching();
            var result = solution.VideoStitching(new int[][] {
                new int[] { 0, 4 },
                new int[] { 2, 8 },
            }, 5);
            Assert.AreEqual(2, result);
        }
    }
}
