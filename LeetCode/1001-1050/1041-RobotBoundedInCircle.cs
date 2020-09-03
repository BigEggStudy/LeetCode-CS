//-----------------------------------------------------------------------------
// Runtime: 68ms
// Memory Usage: 22 MB
// Link: https://leetcode.com/submissions/detail/375100171/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1041_RobotBoundedInCircle
    {
        public bool IsRobotBounded(string instructions)
        {
            var directions = new int[4][] { new int[2] { 0, 1 }, new int[2] { 1, 0 }, new int[2] { 0, -1 }, new int[2] { -1, 0 } };
            int x = 0, y = 0, dir = 0;

            foreach (var ch in instructions)
            {
                if (ch == 'L')
                    dir = (dir + 3) % 4;
                else if (ch == 'R')
                    dir = (dir + 1) % 4;
                else
                {
                    x += directions[dir][0];
                    y += directions[dir][1];
                }
            }

            return (x == 0 && y == 0) || (dir != 0);
        }
    }
}
