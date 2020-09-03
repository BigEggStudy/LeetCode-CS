//-----------------------------------------------------------------------------
// Runtime: 380ms
// Memory Usage: 35.5 MB
// Link: https://leetcode.com/submissions/detail/373295514/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0529_Minesweeper
    {
        private static readonly (int dr, int dc)[] directions = { (0, 1), (0, -1), (1, 0), (-1, 0), (1, 1), (1, -1), (-1, 1), (-1, -1) };

        public char[][] UpdateBoard(char[][] board, int[] click)
        {
            if (board[click[0]][click[1]] == 'M')
            {
                board[click[0]][click[1]] = 'X';
                return board;
            }

            int N = board.Length;
            int M = board[0].Length;

            var visisted = new HashSet<(int r, int c)>();
            var queue = new Queue<(int r, int c)>();
            queue.Enqueue((click[0], click[1]));

            var adjList = new List<(int r, int c)>();
            while (queue.Count > 0)
            {
                (int r, int c) = queue.Dequeue();
                if (visisted.Contains((r, c))) continue;
                visisted.Add((r, c));

                board[r][c] = 'B';

                adjList.Clear();

                var count = 0;
                foreach (var dir in directions)
                {
                    var newR = r + dir.dr;
                    var newC = c + dir.dc;

                    if (newR < 0 || newR >= N || newC < 0 || newC >= M) continue;

                    if (board[newR][newC] == 'E')
                        adjList.Add((newR, newC));
                    if (board[newR][newC] == 'M')
                        count++;
                }

                if (count == 0)
                    foreach ((int newR, int newC) in adjList)
                        queue.Enqueue((newR, newC));
                else
                    board[r][c] = (char)('0' + count);
            }

            return board;
        }
    }
}
