//-----------------------------------------------------------------------------
// Runtime: 488ms
// Memory Usage: 52 MB
// Link: https://leetcode.com/submissions/detail/383925072/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _0715_RangeModule
    {
        private readonly SortedList<int, int> list;

        public _0715_RangeModule()
        {
            list = new SortedList<int, int>();
        }

        public void AddRange(int left, int right)
        {
            var leftIndex = GetIndex(left);
            if (leftIndex >= 0) left = list.Keys[leftIndex];
            else leftIndex = ~leftIndex;

            var rightIndex = GetIndex(right);
            if (rightIndex >= 0) right = list.Values[rightIndex];
            else rightIndex = ~rightIndex - 1;

            for (int i = leftIndex; i <= rightIndex; i++)
                list.RemoveAt(leftIndex);

            list[left] = right;
        }

        public bool QueryRange(int left, int right)
        {
            var leftIndex = GetIndex(left);
            var rightIndex = GetIndex(right);
            return leftIndex == rightIndex && leftIndex >= 0;
        }

        public void RemoveRange(int left, int right)
        {
            var leftIndex = GetIndex(left);
            var rightIndex = GetIndex(right);

            if (rightIndex >= 0)
                list[right] = list.Values[rightIndex];
            else
                rightIndex = ~rightIndex - 1;

            if (leftIndex >= 0)
            {
                list[list.Keys[leftIndex]] = left;
                leftIndex++;
            }
            else
                leftIndex = ~leftIndex;

            for (int i = leftIndex; i <= rightIndex; i++)
                list.RemoveAt(leftIndex);
        }

        private int GetIndex(int value)
        {
            var index = Array.BinarySearch(list.Keys.ToArray(), value);
            if (index >= 0) return index;

            index = ~index;
            if (index > 0 && list.Values[index - 1] >= value)
                return index - 1;
            else
                return ~index;
        }
    }

    /**
     * Your RangeModule object will be instantiated and called as such:
     * RangeModule obj = new RangeModule();
     * obj.AddRange(left,right);
     * bool param_2 = obj.QueryRange(left,right);
     * obj.RemoveRange(left,right);
     */
}
