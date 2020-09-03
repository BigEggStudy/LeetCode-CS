//-----------------------------------------------------------------------------
// Runtime: 152ms
// Memory Usage: 33.2 MB
// Link: https://leetcode.com/submissions/detail/328774038/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0346_MovingAverageFromDataStream
    {
        private readonly Queue<int> queue;
        private readonly int windowSize;
        private double sum;

        /** Initialize your data structure here. */
        public _0346_MovingAverageFromDataStream(int size)
        {
            queue = new Queue<int>(size);
            windowSize = size;
            sum = 0.0;
        }

        public double Next(int val)
        {
            if (queue.Count == windowSize)
                sum -= queue.Dequeue();

            sum += val;
            queue.Enqueue(val);
            return sum / queue.Count;
        }
    }

    /**
     * Your MovingAverage object will be instantiated and called as such:
     * MovingAverage obj = new MovingAverage(size);
     * double param_1 = obj.Next(val);
     */
}
