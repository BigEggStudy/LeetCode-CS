//-----------------------------------------------------------------------------
// Runtime: 76ms
// Memory Usage: 22.2 MB
// Link: https://leetcode.com/submissions/detail/352323904/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0551_StudentAttendanceRecordI
    {
        public bool CheckRecord(string s)
        {
            int countA = 0, countL = 0;
            foreach (var ch in s)
            {
                if (ch == 'A')
                {
                    countA++;
                    countL = 0;
                }
                else if (ch == 'L')
                    countL++;
                else
                    countL = 0;
                if (countA > 1 || countL > 2) return false;
            }

            return true;
        }
    }
}
