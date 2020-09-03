//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 24 MB
// Link: https://leetcode.com/submissions/detail/351844879/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0232_ImplementQueueUsingStacks
    {
        private readonly Stack<int> s1;
        private readonly Stack<int> s2;
        private int s1Front;


        /** Initialize your data structure here. */
        public _0232_ImplementQueueUsingStacks()
        {
            s1 = new Stack<int>();
            s2 = new Stack<int>();
        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            if (s1.Count == 0)
                s1Front = x;
            s1.Push(x);
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            if (s2.Count == 0)
                while (s1.Count > 0)
                    s2.Push(s1.Pop());

            return s2.Pop();
        }

        /** Get the front element. */
        public int Peek()
        {
            if (s2.Count > 0)
                return s2.Peek();

            return s1Front;
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return s1.Count == 0 && s2.Count == 0;
        }
    }

    /**
     * Your MyQueue object will be instantiated and called as such:
     * MyQueue obj = new MyQueue();
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * int param_3 = obj.Peek();
     * bool param_4 = obj.Empty();
     */
}
