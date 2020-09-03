//-----------------------------------------------------------------------------
// Runtime: 248ms
// Memory Usage: 43.8 MB
// Link: https://leetcode.com/submissions/detail/328774632/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0359_LoggerRateLimiter
    {
        private readonly IDictionary<string, int> logHistory;

        /** Initialize your data structure here. */
        public _0359_LoggerRateLimiter()
        {
            logHistory = new Dictionary<string, int>();
        }

        /** Returns true if the message should be printed in the given timestamp, otherwise returns false.
            If this method returns false, the message will not be printed.
            The timestamp is in seconds granularity. */
        public bool ShouldPrintMessage(int timestamp, string message)
        {
            if (!logHistory.ContainsKey(message))
            {
                logHistory.Add(message, timestamp);
                return true;
            }

            if (logHistory[message] <= timestamp - 10)
            {
                logHistory[message] = timestamp;
                return true;
            }

            return false;
        }
    }
}
