//-----------------------------------------------------------------------------
// Runtime: 696ms
// Memory Usage: 77.6 MB
// Link: https://leetcode.com/submissions/detail/331668261/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _1429_FirstUniqueNumber
    {
        private readonly IDictionary<int, DoubleLinkNode> hashMap;
        private readonly DoubleLinkNode dummyHead;
        private readonly DoubleLinkNode dummyTail;

        public _1429_FirstUniqueNumber(int[] nums)
        {
            this.hashMap = new Dictionary<int, DoubleLinkNode>();
            this.dummyHead = new DoubleLinkNode();
            this.dummyTail = new DoubleLinkNode();

            dummyHead.Next = dummyTail;
            dummyTail.Prev = dummyHead;

            foreach (var num in nums)
                Add(num);
        }

        public int ShowFirstUnique()
        {
            if (dummyHead.Next != dummyTail)
                return dummyHead.Next.Value;
            else
                return -1;
        }

        public void Add(int value)
        {
            if (hashMap.ContainsKey(value))
            {
                if (hashMap[value] != null)
                {
                    var node = hashMap[value];
                    hashMap[value] = null;
                    RemoveNode(node);
                }
                return;
            }

            var newNode = new DoubleLinkNode()
            {
                Value = value
            };
            hashMap.Add(value, newNode);
            AddNodeToTail(newNode);
        }

        private void RemoveNode(DoubleLinkNode node)
        {
            var previous = node.Prev;
            var next = node.Next;

            previous.Next = next;
            next.Prev = previous;
        }

        private void AddNodeToTail(DoubleLinkNode node)
        {
            var prev = dummyTail.Prev;

            node.Prev = prev;
            prev.Next = node;

            dummyTail.Prev = node;
            node.Next = dummyTail;
        }


        public class DoubleLinkNode
        {
            public int Value { get; set; }
            public DoubleLinkNode Prev { get; set; }
            public DoubleLinkNode Next { get; set; }
        }
    }

    /**
     * Your FirstUnique object will be instantiated and called as such:
     * FirstUnique obj = new FirstUnique(nums);
     * int param_1 = obj.ShowFirstUnique();
     * obj.Add(value);
     */
}
