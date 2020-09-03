//-----------------------------------------------------------------------------
// Runtime: 104ms
// Memory Usage: 24.4 MB
// Link: https://leetcode.com/submissions/detail/369498426/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0362_DesignHitCounter
    {
        private readonly Queue<int> queue;

        /** Initialize your data structure here. */
        public _0362_DesignHitCounter()
        {
            queue = new Queue<int>();
        }

        /** Record a hit.
            @param timestamp - The current timestamp (in seconds granularity). */
        public void Hit(int timestamp)
        {
            while (queue.Count > 0 && queue.Peek() <= timestamp - 300)
                queue.Dequeue();

            queue.Enqueue(timestamp);
        }

        /** Return the number of hits in the past 5 minutes.
            @param timestamp - The current timestamp (in seconds granularity). */
        public int GetHits(int timestamp)
        {
            while (queue.Count > 0 && queue.Peek() <= timestamp - 300)
                queue.Dequeue();

            return queue.Count;
        }
    }

    /**
     * Your HitCounter object will be instantiated and called as such:
     * HitCounter obj = new HitCounter();
     * obj.Hit(timestamp);
     * int param_2 = obj.GetHits(timestamp);
     */
}
