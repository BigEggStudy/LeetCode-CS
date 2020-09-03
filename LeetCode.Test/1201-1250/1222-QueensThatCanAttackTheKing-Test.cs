using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _1222_QueensThatCanAttackTheKing_Test
    {
        [TestMethod]
        public void QueensAttacktheKing_1()
        {
            var solution = new _1222_QueensThatCanAttackTheKing();
            var result = solution.QueensAttacktheKing(new int[][] {
                new int[] { 0, 1 },
                new int[] { 1, 0 },
                new int[] { 4, 0 },
                new int[] { 0, 4 },
                new int[] { 3, 3 },
                new int[] { 2, 4 },
            }, new int[] { 0, 0 });
            AssertHelper.AssertList(new List<IList<int>>() {
                new int[] { 0, 1 },
                new int[] { 1, 0 },
                new int[] { 3, 3 },
            }, result);
        }

        [TestMethod]
        public void QueensAttacktheKing_2()
        {
            var solution = new _1222_QueensThatCanAttackTheKing();
            var result = solution.QueensAttacktheKing(new int[][] {
                new int[] { 0, 0 },
                new int[] { 1, 1 },
                new int[] { 2, 2 },
                new int[] { 3, 4 },
                new int[] { 3, 5 },
                new int[] { 4, 4 },
                new int[] { 4, 5 },
            }, new int[] { 3, 3 });
            AssertHelper.AssertList(new List<IList<int>>() {
                new int[] { 2, 2 },
                new int[] { 3, 4 },
                new int[] { 4, 4 },
            }, result);
        }

        [TestMethod]
        public void QueensAttacktheKing_3()
        {
            var solution = new _1222_QueensThatCanAttackTheKing();
            var result = solution.QueensAttacktheKing(new int[][] {
                new int[] { 5, 6 },
                new int[] { 7, 7 },
                new int[] { 2, 1 },
                new int[] { 0, 7 },
                new int[] { 1, 6 },
                new int[] { 5, 1 },
                new int[] { 3, 7 },
                new int[] { 0, 3 },
                new int[] { 4, 0 },
                new int[] { 1, 2 },
                new int[] { 6, 3 },
                new int[] { 5, 0 },
                new int[] { 0, 4 },
                new int[] { 2, 2 },
                new int[] { 1, 1 },
                new int[] { 6, 4 },
                new int[] { 5, 4 },
                new int[] { 0, 0 },
                new int[] { 2, 6 },
                new int[] { 4, 5 },
                new int[] { 5, 2 },
                new int[] { 1, 4 },
                new int[] { 7, 5 },
                new int[] { 2, 3 },
                new int[] { 0, 5 },
                new int[] { 4, 2 },
                new int[] { 1, 0 },
                new int[] { 2, 7 },
                new int[] { 0, 1 },
                new int[] { 4, 6 },
                new int[] { 6, 1 },
                new int[] { 0, 6 },
                new int[] { 4, 3 },
                new int[] { 1, 7 },
            }, new int[] { 3, 4 });
            AssertHelper.AssertList(new List<IList<int>>() {
                new int[] { 2, 3 },
                new int[] { 1, 4 },
                new int[] { 1, 6 },
                new int[] { 3, 7 },
                new int[] { 4, 3 },
                new int[] { 5, 4 },
                new int[] { 4, 5 },
            }, result);
        }
    }
}
