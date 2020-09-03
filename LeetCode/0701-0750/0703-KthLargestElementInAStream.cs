//-----------------------------------------------------------------------------
// Runtime: 200ms
// Memory Usage: 40.4 MB
// Link: https://leetcode.com/submissions/detail/345114657/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _0703_KthLargestElementInAStream
    {
        private readonly IDictionary<int, int> minHeap;
        private readonly int k;
        private int size = 0;

        public _0703_KthLargestElementInAStream(int k, int[] nums)
        {
            this.k = k;
            minHeap = new SortedDictionary<int, int>();
            foreach (var num in nums)
                Add(num);
        }

        public int Add(int val)
        {
            if (minHeap.ContainsKey(val))
                minHeap[val]++;
            else
                minHeap[val] = 1;
            size++;

            if (size > k)
            {
                var pair = minHeap.First();
                if (pair.Value > 1)
                    minHeap[pair.Key]--;
                else
                    minHeap.Remove(pair.Key);

                size--;
            }

            return minHeap.Keys.First();
        }
    }

    /**
     * Your KthLargest object will be instantiated and called as such:
     * KthLargest obj = new KthLargest(k, nums);
     * int param_1 = obj.Add(val);
     */
}
