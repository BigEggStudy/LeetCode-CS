//-----------------------------------------------------------------------------
// Runtime: 432ms
// Memory Usage: 50.7 MB
// Link: https://leetcode.com/submissions/detail/368876357/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    /*
    // Definition for an Interval.
    public class Interval {
        public int start;
        public int end;
    
        public Interval(){}
        public Interval(int _start, int _end) {
            start = _start;
            end = _end;
        }
    }
    */

    public class _0759_EmployeeFreeTime
    {
        public IList<Interval> EmployeeFreeTime(IList<IList<Interval>> schedule)
        {
            var events = new List<Interval>();
            foreach (var s in schedule)
                foreach (var i in s)
                    events.Add(i);

            events.Sort(Comparer<Interval>.Create((a, b) => a.start.CompareTo(b.start)));

            var result = new List<Interval>();
            var pre = events[0];
            for (int i = 1; i < events.Count; i++)
            {
                if (events[i].start <= pre.end && events[i].end > pre.end)
                    pre.end = events[i].end;
                else if (events[i].start > pre.end)
                {
                    result.Add(new Interval(pre.end, events[i].start));
                    pre = events[i];
                }
            }

            return result;
        }
    }
}
