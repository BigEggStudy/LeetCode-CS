//-----------------------------------------------------------------------------
// Runtime: 244ms
// Memory Usage: 31.9 MB
// Link: https://leetcode.com/submissions/detail/361605384/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0957_PrisonCellsAfterNDays
    {
        public int[] PrisonAfterNDays(int[] cells, int N)
        {
            var cache = new Dictionary<string, int>();
            var fastForward = false;

            while (N > 0)
            {
                if (!fastForward)
                {
                    var key = string.Join(",", cells);
                    if (cache.ContainsKey(key))
                    {
                        var length = cache[key] - N;
                        N %= length;
                        fastForward = true;
                    }
                    else
                        cache.Add(key, N);
                }

                if (N > 0)
                {
                    cells = NextDay(cells);
                    N--;
                }
            }

            return cells;
        }

        private int[] NextDay(int[] cells)
        {
            int[] newCells = new int[cells.Length];
            newCells[0] = 0;
            for (int i = 1; i < cells.Length - 1; i++)
                newCells[i] = (cells[i - 1] == cells[i + 1]) ? 1 : 0;
            newCells[cells.Length - 1] = 0;
            return newCells;
        }
    }
}
