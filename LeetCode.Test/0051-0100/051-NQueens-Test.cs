using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _051_NQueens_Test
    {
        [TestMethod]
        public void SolveNQueensTest_NEqualZero()
        {
            var solution = new _051_NQueens();
            var result = solution.SolveNQueens(0);

            Assert.AreEqual(1, result.Count);
        }

        [TestMethod]
        public void SolveNQueensTest_NEqualOne()
        {
            var solution = new _051_NQueens();
            var result = solution.SolveNQueens(1);

            Assert.AreEqual(1, result.Count);
        }

        [TestMethod]
        public void SolveNQueensTest_NEqualTwo()
        {
            var solution = new _051_NQueens();
            var result = solution.SolveNQueens(2);

            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void SolveNQueensTest_NEqualThree()
        {
            var solution = new _051_NQueens();
            var result = solution.SolveNQueens(3);

            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void SolveNQueensTest_NEqualFour()
        {
            var solution = new _051_NQueens();
            var result = solution.SolveNQueens(4);

            AssertHelper.AssertList(new List<IList<string>>()
            {
                new List<string>
                {
                    ".Q..",
                    "...Q",
                    "Q...",
                    "..Q."
                },
                new List<string>
                {
                    "..Q.",
                    "Q...",
                    "...Q",
                    ".Q.."
                }
            }, result);
        }


        void AssertQueens(IList<IList<string>> expected, IList<IList<string>> actual)
        {
            Assert.AreEqual(expected.Count, actual.Count);

            for (int i = 0; i < expected.Count; i++)
            {
                for (int j = 0; j < expected[i].Count; j++)
                {
                    Assert.AreEqual(expected[i][j], actual[i][j]);
                }
            }
        }
    }
}
