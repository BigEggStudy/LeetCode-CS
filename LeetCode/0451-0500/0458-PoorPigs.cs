//-----------------------------------------------------------------------------
// Runtime: 36ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0458_PoorPigs
    {
        public int PoorPigs(int buckets, int minutesToDie, int minutesToTest)
        {
            int states = minutesToTest / minutesToDie + 1;
            return (int)Math.Ceiling(Math.Log(buckets) / Math.Log(states));
        }
    }
}
