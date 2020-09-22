//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 25.2 MB
// Link: https://leetcode.com/submissions/detail/399393656/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    /*
    // Definition for a Node.
    public class Node {
        public int val;
        public Node next;
    
        public Node() {}
    
        public Node(int _val) {
            val = _val;
            next = null;
        }
    
        public Node(int _val, Node _next) {
            val = _val;
            next = _next;
        }
    }
    */

    public class _0708_InsertIntoASortedCircularLinkedList
    {
        public Node Insert(Node head, int insertVal)
        {
            if (head == null)
            {
                Node newNode = new Node(insertVal, null);
                newNode.next = newNode;
                return newNode;
            }

            Node prev = head;
            Node curr = head.next;
            do
            {
                if (prev.val <= insertVal && insertVal <= curr.val)
                    break;
                else if (prev.val > curr.val)
                    if (insertVal >= prev.val || insertVal <= curr.val)
                        break;

                prev = curr;
                curr = curr.next;
            } while (prev != head);

            prev.next = new Node(insertVal, curr);
            return head;
        }

        public class Node
        {
            public int val;
            public Node next;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
                next = null;
            }

            public Node(int _val, Node _next)
            {
                val = _val;
                next = _next;
            }
        }
    }
}
