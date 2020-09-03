//-----------------------------------------------------------------------------
// Runtime: 100ms
// Memory Usage: 24.6 MB
// Link: https://leetcode.com/submissions/detail/343728241/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _1275_FindWinnerOnATicTacToeGame
    {
        public string Tictactoe(int[][] moves)
        {
            int d1 = 0, d2 = 0;
            var rows = new int[3];
            var cols = new int[3];

            int turn = 1;
            foreach (var move in moves)
            {
                int r = move[0];
                int c = move[1];

                if (r == c) d1 += turn;
                if (r + c == 2) d2 += turn;
                rows[r] += turn;
                cols[c] += turn;

                if (Math.Abs(d1) == 3 || Math.Abs(d2) == 3 ||
                    Math.Abs(rows[r]) == 3 || Math.Abs(cols[c]) == 3)
                    return turn == 1 ? "A" : "B";

                turn *= -1;
            }

            return moves.Length == 9 ? "Draw" : "Pending";
        }
    }
}
