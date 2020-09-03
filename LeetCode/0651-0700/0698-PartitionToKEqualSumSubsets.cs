//-----------------------------------------------------------------------------
// Runtime: 80ms
// Memory Usage: 24.5 MB
// Link: https://leetcode.com/submissions/detail/381907744/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0698_PartitionToKEqualSumSubsets
    {
        public bool CanPartitionKSubsets(int[] nums, int k)
        {
            int sum = 0, max = int.MinValue;
            foreach (var num in nums)
            {
                sum += num;
                max = Math.Max(max, num);
            }

            if (max > sum / k || sum % k != 0) return false;
            return CanPartitionKSubsets(nums, k, new bool[nums.Length], sum / k, 0, 0);
        }

        private bool CanPartitionKSubsets(int[] nums, int k, bool[] visited, int target, int current, int index)
        {
            if (k == 1) return true;
            if (target == current)
                return CanPartitionKSubsets(nums, k - 1, visited, target, 0, 0);

            for (int i = index; i < nums.Length; i++)
            {
                if (visited[i]) continue;
                if (current + nums[i] > target) continue;

                visited[i] = true;

                if (CanPartitionKSubsets(nums, k, visited, target, current + nums[i], i + 1))
                    return true;

                visited[i] = false;
            }

            return false;
        }
    }
}
