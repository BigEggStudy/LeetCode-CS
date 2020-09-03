//-----------------------------------------------------------------------------
// Runtime: 100ms
// Memory Usage: 27.3 MB
// Link: https://leetcode.com/submissions/detail/351048470/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1460_MakeTwoArraysEqualByReversingSubArrays
    {
        public bool CanBeEqual(int[] target, int[] arr)
        {
            var counts = new int[1001];
            foreach (var num in target)
                counts[num]++;

            foreach (var num in arr)
            {
                if (counts[num] == 0) return false;
                counts[num]--;
            }

            return true;
        }
    }
}
