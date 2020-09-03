//-----------------------------------------------------------------------------
// Runtime: 132ms
// Memory Usage: 34.8 MB
// Link: https://leetcode.com/submissions/detail/322878007/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0155_MinStack
    {
        private Node head;

        /** initialize your data structure here. */
        public _0155_MinStack()
        {
            head = null;
        }

        public void Push(int x)
        {
            if (head == null)
                head = new Node(x, x);
            else
                head = new Node(x, Math.Min(x, head.MinValue), head);
        }

        public void Pop()
        {
            head = head.Next;
        }

        public int Top()
        {
            return head.Value;
        }

        public int GetMin()
        {
            return head.MinValue;
        }

        private class Node
        {
            public Node(int value, int minValue, Node next = null)
            {
                Value = value;
                MinValue = minValue;
                Next = next;
            }


            public int Value { get; set; }
            public int MinValue { get; set; }
            public Node Next { get; set; }
        }
    }
}
