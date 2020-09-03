//-----------------------------------------------------------------------------
// Runtime: 100ms
// Memory Usage: 25.3 MB
// Link: https://leetcode.com/submissions/detail/380544121/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0215_KthLargestElementInAnArray
    {
        public int FindKthLargest(int[] nums, int k)
        {
            Suffle(nums);
            Quick3WaySort(nums, 0, nums.Length - 1, k);
            return nums[k - 1];
        }

        private void Suffle(int[] nums)
        {
            var random = new Random();
            int N = nums.Length;
            int r, temp;
            for (int i = 0; i < N; i++)
            {
                r = random.Next(i + 1);

                temp = nums[r];
                nums[r] = nums[i];
                nums[i] = temp;
            }
        }

        private void Swap(int[] nums, int i, int j)
        {
            var temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        private void Quick3WaySort(int[] nums, int lo, int hi, int k)
        {
            if (lo >= hi) return;
            if (lo >= k) return;
            if (hi < k - 1) return;

            int lt = hi, gt = lo, i = lo;
            int pivot = nums[i];
            while (i <= lt)
            {
                if (nums[i] > pivot)
                    Swap(nums, gt++, i);
                else if (nums[i] < pivot)
                    Swap(nums, lt--, i);
                else
                    i++;
            }

            Quick3WaySort(nums, lo, gt - 1, k);
            Quick3WaySort(nums, lt + 1, hi, k);
        }
    }
}
