using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0130_SurroundedRegions_Test
    {
        [TestMethod]
        public void SolveTest_1()
        {
            var board = new char[][]
            {
                new char [] { 'X', 'X', 'X', 'X' },
                new char [] { 'X', 'O', 'O', 'X' },
                new char [] { 'X', 'X', 'O', 'X' },
                new char [] { 'X', 'O', 'X', 'X' },
            };

            var solution = new _0130_SurroundedRegions();
            solution.Solve(board);
            AssertHelper.AssertArray(new char[][]
            {
                new char [] { 'X', 'X', 'X', 'X' },
                new char [] { 'X', 'X', 'X', 'X' },
                new char [] { 'X', 'X', 'X', 'X' },
                new char [] { 'X', 'O', 'X', 'X' },
            }, board);
        }

        [TestMethod]
        public void SolveTest_2()
        {
            var board = new char[][]
            {
                new char [] { 'X', 'X', 'X', 'X' },
                new char [] { 'X', 'O', 'O', 'X' },
            };

            var solution = new _0130_SurroundedRegions();
            solution.Solve(board);
            AssertHelper.AssertArray(new char[][]
            {
                new char [] { 'X', 'X', 'X', 'X' },
                new char [] { 'X', 'O', 'O', 'X' },
            }, board);
        }
        
        [TestMethod]
        public void SolveTest_3()
        {
            var board = new char[][]
            {
                new char [] { 'X', 'X' },
                new char [] { 'X', 'O' },
                new char [] { 'X', 'X' },
                new char [] { 'X', 'O' },
            };

            var solution = new _0130_SurroundedRegions();
            solution.Solve(board);
            AssertHelper.AssertArray(new char[][]
            {
                new char [] { 'X', 'X' },
                new char [] { 'X', 'O' },
                new char [] { 'X', 'X' },
                new char [] { 'X', 'O' },
            }, board);
        }
    }
}
