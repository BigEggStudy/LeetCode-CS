//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0681_NextClosestTime
    {
        public string NextClosestTime(string time)
        {
            var startTime = 60 * int.Parse(time.Substring(0, 2));
            startTime += int.Parse(time.Substring(3));

            var allowedCharacters = new HashSet<int>();
            foreach (var ch in time)
                if (ch != ':') allowedCharacters.Add(ch - '0');

            const int ONE_DAY = 24 * 60;

            var result_hour = 0;
            var result_minute = 0;
            var offset = int.MaxValue;
            foreach (var h1 in allowedCharacters)
                foreach (var h2 in allowedCharacters)
                {
                    var hour = h1 * 10 + h2;
                    if (hour < 24)
                        foreach (var m1 in allowedCharacters)
                            foreach (var m2 in allowedCharacters)
                            {
                                var minute = m1 * 10 + m2;
                                if (minute < 60)
                                {
                                    int currentTime = 60 * hour + minute;
                                    if (currentTime <= startTime) currentTime += ONE_DAY;

                                    var new_offset = currentTime - startTime;
                                    if (new_offset < offset)
                                    {
                                        offset = new_offset;
                                        result_hour = hour;
                                        result_minute = minute;
                                    }
                                }
                            }
                }
            return $"{result_hour:D2}:{result_minute:D2}";
        }
    }
}
