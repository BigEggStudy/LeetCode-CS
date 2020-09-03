//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 24.9 MB
// Link: https://leetcode.com/submissions/detail/340975735/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1450_NumberOfStudentsDoingHomeworkAtAGivenTime
    {
        public int BusyStudent(int[] startTime, int[] endTime, int queryTime)
        {
            var n = startTime.Length;

            var result = 0;
            for (int i = 0; i < n; i++)
            {
                if (startTime[i] <= queryTime && endTime[i] >= queryTime)
                    result++;
            }

            return result;
        }
    }
}
