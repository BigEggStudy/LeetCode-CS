//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 24.6 MB
// Link: https://leetcode.com/submissions/detail/365288872/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    /*
    // Definition for a Node.
    public class Node {
        public int val;
        public Node prev;
        public Node next;
        public Node child;
    }
    */

    public class _0430_FlattenAMultilevelDoublyLinkedList
    {
        public Node Flatten(Node head)
        {
            var dummy = new Node();
            dummy.next = head;
            var curr = dummy;

            FlattenHelper(curr);

            return dummy.next;
        }

        private Node FlattenHelper(Node head)
        {
            var curr = head;
            while (curr != null)
            {
                if (curr.child == null)
                {
                    if (curr.next != null)
                    {
                        curr = curr.next;
                        continue;
                    }
                    else
                        break;
                }

                var next = curr.next;
                var nextLevelTail = FlattenHelper(curr.child);
                curr.next = curr.child;
                curr.child.prev = curr;
                curr.child = null;
                nextLevelTail.next = next;
                if (next != null)
                    next.prev = nextLevelTail;
            }

            return curr;
        }

        public class Node
        {
            public int val;
            public Node prev;
            public Node next;
            public Node child;
        }
    }
}
