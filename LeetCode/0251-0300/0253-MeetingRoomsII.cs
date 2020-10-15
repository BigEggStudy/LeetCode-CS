//-----------------------------------------------------------------------------
// Runtime: 104ms
// Memory Usage: 28 MB
// Link: https://leetcode.com/submissions/detail/409212378/
//-----------------------------------------------------------------------------

using System.Linq;

namespace LeetCode
{
    public class _0253_MeetingRoomsII
    {
        public int MinMeetingRooms(int[][] intervals)
        {
            if (intervals.Length == 0) return 0;

            var starts = intervals.Select(i => i[0]).OrderBy(i => i).ToArray();
            var ends = intervals.Select(i => i[1]).OrderBy(i => i).ToArray();

            int start = 0, end = 0;
            for (; start < intervals.Length; start++)
                if (starts[start] >= ends[end])
                    end++;

            return start - end;
        }
    }
}
