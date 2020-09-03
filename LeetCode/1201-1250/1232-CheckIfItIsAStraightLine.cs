//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 26 MB
// Link: https://leetcode.com/submissions/detail/336524219/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1232_CheckIfItIsAStraightLine
    {
        public bool CheckStraightLine(int[][] coordinates)
        {
            int dY = coordinates[1][1] - coordinates[0][1];
            int dX = coordinates[1][0] - coordinates[0][0];
            for (int i = 2; i < coordinates.Length; i++)
            {
                if (dX * (coordinates[i][1] - coordinates[0][1]) != dY * (coordinates[i][0] - coordinates[0][0]))
                    return false;
            }
            return true;
        }
    }
}
