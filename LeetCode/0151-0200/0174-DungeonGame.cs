//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 25 MB
// Link: https://leetcode.com/submissions/detail/356829519/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0174_DungeonGame
    {
        public int CalculateMinimumHP(int[][] dungeon)
        {
            var rows = dungeon.Length;
            var cols = dungeon[0].Length;

            for (int i = rows - 1; i >= 0; i--)
                for (int j = cols - 1; j >= 0; j--)
                {
                    if (i == rows - 1 && j == cols - 1) continue;

                    int rightValue = int.MinValue, downValue = int.MinValue;
                    var current = dungeon[i][j];

                    if (i < cols - 1) rightValue = current > 0 ? current + dungeon[i + 1][j] : Math.Min(current, current + dungeon[i + 1][j]);
                    if (j < rows - 1) downValue = current > 0 ? current + dungeon[i][j + 1] : Math.Min(current, current + dungeon[i][j + 1]);
                    dungeon[i][j] = Math.Max(rightValue, downValue);
                }

            return dungeon[0][0] <= 0 ? 1 - dungeon[0][0] : 1;
        }
    }
}
