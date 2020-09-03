//-----------------------------------------------------------------------------
// Runtime: 300ms
// Memory Usage: 35.3 MB
// Link: https://leetcode.com/submissions/detail/378084324/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _015_3Sum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var results = new List<IList<int>>();
            if (nums.Length < 3) return results;

            Suffle(nums);
            Quick3WaySort(nums, 0, nums.Length - 1);

            if (nums[0] > 0) return results;
            if (nums[nums.Length - 1] < 0) return results;

            for (int i = 0; i < nums.Length - 2 && nums[i] <= 0; i++)
            {
                int lo = i + 1, hi = nums.Length - 1;
                while (lo < hi && nums[hi] >= 0)
                {
                    var sum = nums[i] + nums[lo] + nums[hi];
                    if (sum < 0)
                        do
                            lo++;
                        while (lo < hi && nums[lo - 1] == nums[lo]);
                    else if (sum > 0)
                        do
                            hi--;
                        while (lo < hi && nums[hi] == nums[hi + 1]);
                    else
                    {
                        results.Add(new List<int>() { nums[i], nums[lo], nums[hi] });
                        do
                            lo++;
                        while (lo < hi && nums[lo - 1] == nums[lo]);
                        do
                            hi--;
                        while (lo < hi && nums[hi] == nums[hi + 1]);
                    }
                }

                while (i < nums.Length - 2 && nums[i] == nums[i + 1])
                    i++;
            }
            return results;
        }

        void Suffle(int[] nums)
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

        void Quick3WaySort(int[] nums, int lo, int hi)
        {
            if (lo >= hi) { return; }
            var lt = lo;
            var gt = hi;
            var i = lo;
            var v = nums[i];
            int temp;

            while (i <= gt)
            {
                if (nums[i] > v)
                {
                    temp = nums[i];
                    nums[i] = nums[gt];
                    nums[gt--] = temp;
                }
                else if (nums[i] < v)
                {
                    temp = nums[i];
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
