//-----------------------------------------------------------------------------
// Runtime: 112ms
// Memory Usage: 27.2 MB
// Link: https://leetcode.com/submissions/detail/371657822/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _0773_SlidingPuzzle
    {
        private (int dr, int dc)[] direction = new (int dr, int dc)[4] { (1, 0), (-1, 0), (0, 1), (0, -1) };

        public int SlidingPuzzle(int[][] board)
        {
            State final = new State(new int[2][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 0 },
            });
            State initState = new State(board);

            Queue<State> queue = new Queue<State>();
            ISet<State> visited = new HashSet<State>();

            queue.Enqueue(initState);
            visited.Add(initState);

            int count = 0;
            while (queue.Count > 0)
            {
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    var curr = queue.Dequeue();
                    if (curr.Equals(final)) return count;

                    foreach (var dir in direction)
                    {
                        var next = curr.Move(dir);
                        if (next != null && visited.Add(next))
                        {
                            queue.Enqueue(next);
                        }
                    }
                }

                count++;
            }

            return -1;
        }

        private class State : IEquatable<State>
        {
            private readonly int[][] _board;

            public State(int[][] board)
            {
                _board = board;
            }

            public override bool Equals(object obj) => Equals(obj as State);

            public override int GetHashCode()
            {
                unchecked
                {
                    int res = 0;
                    for (int i = 0; i < 2; i++)
                        for (int j = 0; j < 3; j++)
                        {
                            res *= 10;
                            res += _board[i][j];
                        }
                    return res.GetHashCode();
                }
            }

            public bool Equals(State other)
            {
                for (int i = 0; i < 2; i++)
                    for (int j = 0; j < 3; j++)
                        if (_board[i][j] != other._board[i][j])
                            return false;

                return true;
            }

            private State Clone()
            {
                int[][] newBoard = new int[2][];
                for (int i = 0; i < 2; i++)
                {
                    newBoard[i] = new int[3];
                    for (int j = 0; j < 3; j++)
                        newBoard[i][j] = _board[i][j];
                }

                return new State(newBoard);
            }

            public State Move((int dr, int dc) dir)
            {
                for (int i = 0; i < 2; i++)
                    for (int j = 0; j < 3; j++)
                        if (_board[i][j] == 0)
                        {
                            int newI = i + dir.dr;
                            int newJ = j + dir.dc;

                            if (newI >= 0 && newI < 2 && newJ >= 0 && newJ < 3)
                            {
                                var tmp = _board[i][j];
                                _board[i][j] = _board[newI][newJ];
                                _board[newI][newJ] = tmp;

                                State res = Clone();

                                tmp = _board[i][j];
                                _board[i][j] = _board[newI][newJ];
                                _board[newI][newJ] = tmp;

                                return res;
                            }

                            return null;
                        }

                return null;
            }
        }
    }
}
