//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 23.9 MB
// Link: https://leetcode.com/submissions/detail/352421862/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0225_ImplementStackUsingQueues
    {
        private readonly Queue<int> queue;

        /** Initialize your data structure here. */
        public _0225_ImplementStackUsingQueues()
        {
            queue = new Queue<int>();
        }

        /** Push element x onto stack. */
        public void Push(int x)
        {
            queue.Enqueue(x);
            var i = queue.Count - 1;
            while (i-- > 0)
                queue.Enqueue(queue.Dequeue());
        }

        /** Removes the element on top of the stack and returns that element. */
        public int Pop()
        {
            return queue.Dequeue();
        }

        /** Get the top element. */
        public int Top()
        {
            return queue.Peek();
        }

        /** Returns whether the stack is empty. */
        public bool Empty()
        {
            return queue.Count == 0;
        }
    }

    /**
     * Your MyStack object will be instantiated and called as such:
     * MyStack obj = new MyStack();
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * int param_3 = obj.Top();
     * bool param_4 = obj.Empty();
     */
}
