//-----------------------------------------------------------------------------
// Runtime: 72ms
// Memory Usage: 22.6 MB
// Link: https://leetcode.com/submissions/detail/359556522/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _1496_PathCrossing
    {
        public bool IsPathCrossing(string path)
        {
            var set = new HashSet<(int x, int y)>();
            int x = 0, y = 0;
            set.Add((x, y));

            foreach (var cmd in path)
            {
                if (cmd == 'N') y++;
                else if (cmd == 'S') y--;
                if (cmd == 'E') x++;
                if (cmd == 'W') x--;

                if (set.Contains((x, y)))
                    return true;

                set.Add((x, y));
            }

            return false;
        }
    }
}
