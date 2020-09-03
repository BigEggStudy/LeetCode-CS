using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0200_NumberOfIslands_Test
    {
        [TestMethod]
        public void NumIslandsTest_1()
        {
            var solution = new _0200_NumberOfIslands();
            var result = solution.NumIslands(
                new char[][]
                {
                    new char[] { '1', '1', '1', '1', '0' },
                    new char[] { '1', '1', '0', '1', '0' },
                    new char[] { '1', '1', '0', '0', '0' },
                    new char[] { '0', '0', '0', '0', '0' },
                }
            );
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void NumIslandsTest_2()
        {
            var solution = new _0200_NumberOfIslands();
            var result = solution.NumIslands(
                new char[][]
                {
                    new char[] { '1', '1', '0', '0', '0' },
                    new char[] { '1', '1', '0', '0', '0' },
                    new char[] { '0', '0', '1', '0', '0' },
                    new char[] { '0', '0', '0', '1', '1' },
                }
            );
            Assert.AreEqual(3, result);
        }
    }
}
