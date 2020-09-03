//-----------------------------------------------------------------------------
// Runtime: 268ms
// Memory Usage: 35.8 MB
// Link: https://leetcode.com/submissions/detail/368977279/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0912_SortAnArray
    {
        private readonly Random random = new Random();

        public int[] SortArray(int[] nums)
        {
            Suffle(nums);
            Quick3WaySort(nums, 0, nums.Length - 1);
            return nums;
        }

        void Suffle(int[] nums)
        {
            var random = new Random();
            int N = nums.Length;
            for (int i = 0; i < N; i++)
            {
                var r = random.Next(i + 1);
                var temp = nums[r];
                nums[r] = nums[i];
                nums[i] = temp;
            }
        }

        void Quick3WaySort(int[] nums, int lo, int hi)
        {
            if (lo >= hi) return;
            int lt = lo, gt = hi;
            var i = lo;
            var v = nums[i];

            while (i <= gt)
            {
                if (nums[i] > v)
                {
                    var temp = nums[i];
                    nums[i] = nums[gt];
                    nums[gt--] = temp;
                }
                else if (nums[i] < v)
                {
                    var temp = nums[i];
                    nums[i] = nums[lt];
                    nums[lt++] = temp;
                }
                else { i++; }
            }
            Quick3WaySort(nums, lo, lt - 1);
            Quick3WaySort(nums, gt + 1, hi);
        }
    }
}
