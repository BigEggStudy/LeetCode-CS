//-----------------------------------------------------------------------------
// Runtime: 268ms
// Memory Usage: 50.4 MB
// Link: https://leetcode.com/submissions/detail/366136625/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _0460_LFUCache
    {
        private readonly SortedDictionary<int, LinkedList<int[]>> frequencyList;
        private readonly Dictionary<int, LinkedListNode<int[]>> map;
        private readonly int capacity;

        public _0460_LFUCache(int capacity)
        {
            this.capacity = capacity;
            frequencyList = new SortedDictionary<int, LinkedList<int[]>>();
            map = new Dictionary<int, LinkedListNode<int[]>>();
        }

        public int Get(int key)
        {
            if (!map.ContainsKey(key))
                return -1;
            else
            {
                Reorder(map[key]);
            }

            return map[key].Value[1];
        }

        public void Put(int key, int value)
        {
            if (capacity == 0) return;
            if (map.ContainsKey(key))
                map[key].Value[1] = value;
            else
            {
                if (map.Count >= capacity)
                {
                    int min = frequencyList.Keys.First();
                    map.Remove(frequencyList[min].Last.Value[0]);
                    frequencyList[min].RemoveLast();

                    if (frequencyList[min].Count == 0)
                        frequencyList.Remove(min);
                }

                map.Add(key, new LinkedListNode<int[]>(new int[] { key, value, -1 }));
            }

            Reorder(map[key]);
        }

        private void Reorder(LinkedListNode<int[]> node)
        {
            var freq = node.Value[2];

            if (frequencyList.ContainsKey(freq))
            {
                frequencyList[freq].Remove(node);
                if (frequencyList[freq].Count == 0)
                    frequencyList.Remove(freq);
            }

            freq++;
            node.Value[2]++;

            if (!frequencyList.ContainsKey(freq))
                frequencyList.Add(freq, new LinkedList<int[]>());
            frequencyList[freq].AddFirst(node);
        }
    }

    /**
     * Your LFUCache object will be instantiated and called as such:
     * LFUCache obj = new LFUCache(capacity);
     * int param_1 = obj.Get(key);
     * obj.Put(key,value);
     */
}
