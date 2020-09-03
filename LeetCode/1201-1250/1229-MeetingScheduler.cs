//-----------------------------------------------------------------------------
// Runtime: 416ms
// Memory Usage: 48.5 MB
// Link: https://leetcode.com/submissions/detail/373797121/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _1229_MeetingScheduler
    {
        public IList<int> MinAvailableDuration(int[][] slots1, int[][] slots2, int duration)
        {
            Array.Sort(slots1, (a, b) => a[0].CompareTo(b[0]));
            Array.Sort(slots2, (a, b) => a[0].CompareTo(b[0]));

            int index1 = 0, index2 = 0;
            while (index1 < slots1.Length && index2 < slots2.Length)
            {
                var slot1 = slots1[index1];
                var slot2 = slots2[index2];

                var start = Math.Max(slot1[0], slot2[0]);
                var end = Math.Min(slot1[1], slot2[1]);
                if (end - start >= duration)
                    return new List<int>() { start, start + duration };

                if (slot1[1] < slot2[1])
                    index1++;
                else
                    index2++;
            }

            return new List<int>();
        }
    }
}
