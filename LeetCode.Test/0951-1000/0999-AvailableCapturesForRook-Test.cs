using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0999_AvailableCapturesForRook_Test
    {
        [TestMethod]
        public void NumRookCaptures_1()
        {
            var solution = new _0999_AvailableCapturesForRook();
            var result = solution.NumRookCaptures(new char[][] {
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', 'p', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', 'R', '.', '.', '.', 'p' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', 'p', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
            });
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void NumRookCaptures_2()
        {
            var solution = new _0999_AvailableCapturesForRook();
            var result = solution.NumRookCaptures(new char[][] {
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', 'p', 'p', 'p', 'p', 'p', '.', '.' },
                new char[] { '.', 'p', 'p', 'B', 'p', 'p', '.', '.' },
                new char[] { '.', 'p', 'B', 'R', 'B', 'p', '.', '.' },
                new char[] { '.', 'p', 'p', 'B', 'p', 'p', '.', '.' },
                new char[] { '.', 'p', 'p', 'p', 'p', 'p', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
            });
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void NumRookCaptures_3()
        {
            var solution = new _0999_AvailableCapturesForRook();
            var result = solution.NumRookCaptures(new char[][] {
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', 'p', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', 'p', '.', '.', '.', '.' },
                new char[] { 'p', 'p', '.', 'R', '.', 'p', 'B', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', 'B', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', 'p', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
            });
            Assert.AreEqual(3, result);
        }
    }
}
