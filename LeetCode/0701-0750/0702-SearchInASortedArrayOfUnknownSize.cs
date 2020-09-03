//-----------------------------------------------------------------------------
// Runtime: 160ms
// Memory Usage: 35.3 MB
// Link: https://leetcode.com/submissions/detail/363451622/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    /**
     * // This is ArrayReader's API interface.
     * // You should not implement it, or speculate about its implementation
     * class ArrayReader {
     *     public int Get(int index) {}
     * }
     */

    public class _0702_SearchInASortedArrayOfUnknownSize
    {
        public int Search(ArrayReader reader, int target)
        {
            int left = 0, right = 1;
            while (reader.Get(right) < target)
            {
                left = right;
                right <<= 1;
            }
            while (left <= right)
            {
                var mid = left + (right - left) / 2;
                var value = reader.Get(mid);
                if (value == target) return mid;
                else if (value > target) right = mid - 1;
                else
                    left = mid + 1;
            }

            return -1;
        }

        public class ArrayReader
        {
            private readonly int[] arr;

            public ArrayReader(int[] arr)
            {
                this.arr = arr;
            }

            public int Get(int index)
            {
                if (index >= arr.Length) return int.MaxValue;
                return arr[index];
            }
        }
    }
}
