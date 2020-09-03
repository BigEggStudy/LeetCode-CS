//-----------------------------------------------------------------------------
// Runtime: 132ms
// Memory Usage: 34.9 MB
// Link: https://leetcode.com/submissions/detail/366145745/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0348_DesignTicTacToe
    {
        private readonly int N;
        private readonly int[] rows;
        private readonly int[] cols;
        private int diagonal;
        private int antidiagonal;

        /** Initialize your data structure here. */
        public _0348_DesignTicTacToe(int n)
        {
            N = n;
            rows = new int[n];
            cols = new int[n];
        }

        /** Player {player} makes a move at ({row}, {col}).
            @param row The row of the board.
            @param col The column of the board.
            @param player The player, can be either 1 or 2.
            @return The current winning condition, can be either:
                    0: No one wins.
                    1: Player 1 wins.
                    2: Player 2 wins. */
        public int Move(int row, int col, int player)
        {
            var move = player == 1 ? 1 : -1;
            rows[row] += move;
            cols[col] += move;
            if (row == col) diagonal += move;
            if (row == N - 1 - col) antidiagonal += move;

            if (Math.Abs(rows[row]) == N ||
                Math.Abs(cols[col]) == N ||
                Math.Abs(diagonal) == N ||
                Math.Abs(antidiagonal) == N)
                return player;

            return 0;
        }
    }

    /**
     * Your TicTacToe object will be instantiated and called as such:
     * TicTacToe obj = new TicTacToe(n);
     * int param_1 = obj.Move(row,col,player);
     */
}
