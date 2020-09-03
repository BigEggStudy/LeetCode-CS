//-----------------------------------------------------------------------------
// Runtime: 100ms
// Memory Usage: 26.9 MB
// Link: https://leetcode.com/submissions/detail/342752135/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0252_MeetingRooms
    {
        public bool CanAttendMeetings(int[][] intervals)
        {
            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
            for (int i = 0; i < intervals.Length - 1; i++)
            {
                if (intervals[i][1] > intervals[i + 1][0])
                    return false;
            }

            return true;
        }
    }
}
