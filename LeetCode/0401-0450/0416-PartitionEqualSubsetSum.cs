//-----------------------------------------------------------------------------
// Runtime: 80ms
// Memory Usage: 24.3 MB
// Link: https://leetcode.com/submissions/detail/383853905/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0416_PartitionEqualSubsetSum
    {
        public bool CanPartition(int[] nums)
        {
            int sum = 0, max = int.MinValue;
            foreach (var num in nums)
            {
                sum += num;
                max = Math.Max(num, max);
            }
            if (sum % 2 != 0 || max > sum / 2) return false;
            return CanPartition(nums, 2, new bool[nums.Length], sum / 2, 0, 0);
        }

        private bool CanPartition(int[] nums, int k, bool[] visited, int target, int current, int index)
        {
            if (k == 1) return true;
            if (target == current)
                return CanPartition(nums, k - 1, visited, target, 0, 0);

            for (int i = index; i < nums.Length; i++)
            {
                if (visited[i]) continue;
                if (current + nums[i] > target) continue;

                visited[i] = true;

                if (CanPartition(nums, k, visited, target, current + nums[i], i)) return true;

                visited[i] = false;
                while (i + 1 < nums.Length && nums[i] == nums[i + 1])
                    i++;
            }

            return false;
        }
    }
}
