//-----------------------------------------------------------------------------
// Runtime: 48ms
// Memory Usage: 15 MB
// Link: https://leetcode.com/submissions/detail/366587381/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _1344_AngleBetweenHandsOfAClock
    {
        public double AngleClock(int hour, int minutes)
        {
            if (hour == 12) hour = 0;
            double hourAngle = (hour + (minutes / 60.0)) * 30.0;
            double minuteAngle = minutes * 6.0;

            var diff = Math.Abs(hourAngle - minuteAngle);
            return diff > 180.0 ? diff = 360 - diff : diff;
        }
    }
}
