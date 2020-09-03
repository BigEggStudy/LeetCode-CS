using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0221_MaximalSquare_Test
    {
        [TestMethod]
        public void MaximalSquare_1()
        {
            var solution = new _0221_MaximalSquare();
            var result = solution.MaximalSquare(new char[][] {
                new char[] { '1', '0', '1', '0', '0' },
                new char[] { '1', '0', '1', '1', '1' },
                new char[] { '1', '1', '1', '1', '1' },
                new char[] { '1', '0', '1', '0', '0' },
            });
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void MaximalSquare_2()
        {
            var solution = new _0221_MaximalSquare();
            var result = solution.MaximalSquare(new char[][] {
                new char[] { '0', '1', '1', '1', '0' },
                new char[] { '1', '1', '1', '1', '1' },
                new char[] { '0', '1', '1', '1', '1' },
                new char[] { '0', '1', '1', '1', '1' },
                new char[] { '0', '0', '1', '1', '1' },
            });
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void MaximalSquare_3()
        {
            var solution = new _0221_MaximalSquare();
            var result = solution.MaximalSquare(new char[][] {
                new char[] { '0' },
            });
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void MaximalSquare_4()
        {
            var solution = new _0221_MaximalSquare();
            var result = solution.MaximalSquare(new char[][] {
                new char[] { '1' },
            });
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void MaximalSquare_5()
        {
            var solution = new _0221_MaximalSquare();
            var result = solution.MaximalSquare(new char[][] {
                new char[] { },
            });
            Assert.AreEqual(0, result);
        }
    }
}
