//-----------------------------------------------------------------------------
// Runtime: 244ms
// Memory Usage: 49.8 MB
// Link: https://leetcode.com/submissions/detail/329550034/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0146_LRUCache
    {
        private readonly int capacity;
        private readonly IDictionary<int, DoubleLinkNode> hashMap;
        private readonly DoubleLinkNode dummyHead;
        private readonly DoubleLinkNode dummyTail;
        private int size;

        public _0146_LRUCache(int capacity)
        {
            this.size = 0;
            this.capacity = capacity;
            this.hashMap = new Dictionary<int, DoubleLinkNode>();
            this.dummyHead = new DoubleLinkNode();
            this.dummyTail = new DoubleLinkNode();

            dummyHead.Next = dummyTail;
            dummyTail.Prev = dummyHead;
        }

        public int Get(int key)
        {
            if (!hashMap.ContainsKey(key)) return -1;

            var node = hashMap[key];
            MoveNodeToHead(node);
            return node.Value;
        }

        public void Put(int key, int value)
        {
            if (hashMap.ContainsKey(key))
            {
                var node = hashMap[key];
                node.Value = value;
                MoveNodeToHead(node);
                return;
            }

            var newNode = new DoubleLinkNode()
            {
                Key = key,
                Value = value
            };
            hashMap.Add(key, newNode);
            AddNodeToHead(newNode);
            size++;

            if (size > capacity)
            {
                var node = RemoveLatestNode();
                hashMap.Remove(node.Key);
                size--;
            }
        }


        private void MoveNodeToHead(DoubleLinkNode node)
        {
            RemoveNode(node);
            AddNodeToHead(node);
        }

        private void RemoveNode(DoubleLinkNode node)
        {
            var previous = node.Prev;
            var next = node.Next;

            previous.Next = next;
            next.Prev = previous;
        }

        private void AddNodeToHead(DoubleLinkNode node)
        {
            var next = dummyHead.Next;

            node.Next = next;
            next.Prev = node;

            dummyHead.Next = node;
            node.Prev = dummyHead;
        }

        private DoubleLinkNode RemoveLatestNode()
        {
            var last = dummyTail.Prev;
            RemoveNode(last);
            return last;
        }


        public class DoubleLinkNode
        {
            public int Key { get; set; }
            public int Value { get; set; }
            public DoubleLinkNode Prev { get; set; }
            public DoubleLinkNode Next { get; set; }
        }
    }
}
