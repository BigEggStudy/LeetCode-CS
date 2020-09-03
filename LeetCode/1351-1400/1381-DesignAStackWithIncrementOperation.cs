//-----------------------------------------------------------------------------
// Runtime: 152ms
// Memory Usage: 38.7 MB
// Link: https://leetcode.com/submissions/detail/360764155/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _1381_DesignAStackWithIncrementOperation
    {
        private readonly int[] data;
        private int size;

        public _1381_DesignAStackWithIncrementOperation(int maxSize)
        {
            data = new int[maxSize];
            size = 0;
        }

        public void Push(int x)
        {
            if (size == data.Length) return;
            data[size++] = x;
        }

        public int Pop()
        {
            if (size == 0) return -1;
            return data[--size];
        }

        public void Increment(int k, int val)
        {
            for (int i = 0; i < Math.Min(k, size); i++)
                data[i] += val;
        }
    }

    /**
     * Your CustomStack object will be instantiated and called as such:
     * CustomStack obj = new CustomStack(maxSize);
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * obj.Increment(k,val);
     */
}
