//-----------------------------------------------------------------------------
// Runtime: 76ms
// Memory Usage: 25.7 MB
// Link: https://leetcode.com/submissions/detail/328290374/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0657_RobotReturnToOrigin
    {
        public bool JudgeCircle(string moves)
        {
            var x = 0;
            var y = 0;

            foreach (var ch in moves)
            {
                if (ch == 'U')
                    x++;
                if (ch == 'D')
                    x--;
                if (ch == 'R')
                    y++;
                if (ch == 'L')
                    y--;
            }

            return x == 0 && y == 0;
        }
    }
}
