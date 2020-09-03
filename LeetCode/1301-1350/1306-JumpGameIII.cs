//-----------------------------------------------------------------------------
// Runtime: 116ms
// Memory Usage: 34.5 MB
// Link: https://leetcode.com/submissions/detail/371202136/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _1306_JumpGameIII
    {
        public bool CanReach(int[] arr, int start)
        {
            var seen = new HashSet<int>();
            return DFS(arr, start, seen);
        }

        private bool DFS(int[] arr, int index, HashSet<int> seen)
        {
            if (index >= arr.Length || index < 0) return false;
            if (arr[index] == 0) return true;
            if (seen.Contains(index)) return false;

            seen.Add(index);
            return DFS(arr, index - arr[index], seen) || DFS(arr, index + arr[index], seen);
        }
    }
}
