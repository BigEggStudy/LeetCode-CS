//-----------------------------------------------------------------------------
// Runtime: 252ms
// Memory Usage: 33.1 MB
// Link: https://leetcode.com/submissions/detail/395326352/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _057_InsertInterval
    {
        public IList<Interval> Insert(IList<Interval> intervals, Interval newInterval)
        {
            var result = new List<Interval>();

            for (int i = 0; i < intervals.Count; i++)
            {
                if (newInterval.start > intervals[i].end)
                {
                    result.Add(intervals[i]);
                }
                else if (newInterval.end < intervals[i].start)
                {
                    result.Add(newInterval);
                    for (int j = i; j < intervals.Count; j++)
                    {
                        result.Add(intervals[j]);
                    }
                    return result;
                }
                else
                {
                    newInterval.start = Math.Min(intervals[i].start, newInterval.start);
                    newInterval.end = Math.Max(intervals[i].end, newInterval.end);
                }
            }

            result.Add(newInterval);
            return result;
        }
    }
}
