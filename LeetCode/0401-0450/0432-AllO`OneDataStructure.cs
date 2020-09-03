//-----------------------------------------------------------------------------
// Runtime: 180ms
// Memory Usage: 40.6 MB
// Link: https://leetcode.com/submissions/detail/372507907/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _0432_AllOOneDataStructure
    {
        private Node head, tail;
        private Dictionary<string, Node> map;

        /** Initialize your data structure here. */
        public _0432_AllOOneDataStructure()
        {
            head = new Node();
            tail = new Node();
            head.next = tail;
            tail.prev = head;

            map = new Dictionary<string, Node>();
        }

        /** Inserts a new key <Key> with value 1. Or increments an existing key by 1. */
        public void Inc(string key)
        {
            Node node = null;
            if (map.ContainsKey(key))
                node = map[key];
            else
                node = head;

            var next = node.next;
            if (next.val != node.val + 1)
            {
                next = new Node(node.val + 1);
                AddNode(node, next);
            }
            RemoveKey(key, node);
            AddKey(key, next);
        }

        /** Decrements an existing key by 1. If Key's value is 1, remove it from the data structure. */
        public void Dec(string key)
        {
            if (!map.ContainsKey(key)) return;

            var node = map[key];
            if (node.val == 1)
            {
                map.Remove(key);
                RemoveKey(key, node);
                return;
            }

            var prev = node.prev;
            if (prev.val != node.val - 1)
            {
                prev = new Node(node.val - 1);
                AddNode(node.prev, prev);
            }

            RemoveKey(key, node);
            AddKey(key, prev);
        }

        /** Returns one of the keys with maximal value. */
        public string GetMaxKey()
        {
            if (tail.prev == head) return string.Empty;

            return tail.prev.keys.First();
        }

        /** Returns one of the keys with Minimal value. */
        public string GetMinKey()
        {
            if (head.next == tail) return string.Empty;

            return head.next.keys.First();
        }

        private void AddNode(Node node, Node next)
        {
            next.next = node.next;
            node.next.prev = next;

            next.prev = node;
            node.next = next;
        }

        private void RemoveNode(Node node)
        {
            node.prev.next = node.next;
            node.next.prev = node.prev;
        }

        private void AddKey(string key, Node node)
        {
            map.Add(key, node);
            node.keys.Add(key);
        }

        private void RemoveKey(string key, Node node)
        {
            if (node == head) return;
            node.keys.Remove(key);
            map.Remove(key);

            if (node.keys.Count == 0)
                RemoveNode(node);
        }

        public class Node
        {
            public HashSet<string> keys;
            public Node next, prev;
            public int val;

            public Node(int val = 0)
            {
                this.val = val;
                next = null;
                prev = null;
                keys = new HashSet<string>();
            }
        }
    }

    /**
     * Your AllOne object will be instantiated and called as such:
     * AllOne obj = new AllOne();
     * obj.Inc(key);
     * obj.Dec(key);
     * string param_3 = obj.GetMaxKey();
     * string param_4 = obj.GetMinKey();
     */
}
