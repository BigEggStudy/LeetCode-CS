//-----------------------------------------------------------------------------
// Runtime: 320ms
// Memory Usage: 47.5 MB
// Link: https://leetcode.com/submissions/detail/328751599/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0933_NumberOfRecentCalls
    {
        private readonly Queue<int> queue;

        public _0933_NumberOfRecentCalls()
        {
            queue = new Queue<int>();
        }

        public int Ping(int t)
        {
            queue.Enqueue(t);
            while (t - queue.Peek() > 3000)
                queue.Dequeue();
            return queue.Count;
        }
    }

    /**
     * Your RecentCounter object will be instantiated and called as such:
     * RecentCounter obj = new RecentCounter();
     * int param_1 = obj.Ping(t);
     */
}
