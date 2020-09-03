//-----------------------------------------------------------------------------
// Runtime: 188ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0716_MaxStack
    {
        private Stack<int> stack;
        private Stack<int> maxStack;

        /** initialize your data structure here. */
        public _0716_MaxStack()
        {
            stack = new Stack<int>();
            maxStack = new Stack<int>();
        }

        public void Push(int x)
        {
            if (maxStack.Count == 0)
                maxStack.Push(x);
            else
                if (x >= maxStack.Peek()) maxStack.Push(x);
            stack.Push(x);
        }

        public int Pop()
        {
            var result = stack.Pop();

            if (result == maxStack.Peek()) maxStack.Pop();

            return result;
        }

        public int Top()
        {
            return stack.Peek();
        }

        public int PeekMax()
        {
            return maxStack.Peek();
        }

        public int PopMax()
        {
            var result = maxStack.Pop();

            var tempStack = new Stack<int>();
            while (stack.Peek() != result)
            {
                var value = stack.Pop();
                tempStack.Push(value);
            }

            stack.Pop();

            while (tempStack.Count > 0)
            {
                var value = tempStack.Pop();
                Push(value);
            }

            return result;
        }
    }
}
