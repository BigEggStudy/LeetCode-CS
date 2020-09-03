//-----------------------------------------------------------------------------
// Runtime: 164ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _016_3SumClosest
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            Suffle(nums);
            Quick3WaySort(nums, 0, nums.Length - 1);

            int result = 0, rest = int.MaxValue;
            int sumValue = 0;
            var tempRest = 0;
            int lo = 0, hi = 0;
            for (var index = 0; index < nums.Length - 2; index++)
            {
                lo = index + 1;
                hi = nums.Length - 1;

                while (lo < hi)
                {
                    sumValue = nums[index] + nums[lo] + nums[hi];
                    tempRest = target - sumValue;
                    if (tempRest == 0) { return sumValue; }

                    tempRest = tempRest < 0 ? -tempRest : tempRest;
                    if (tempRest < rest)
                    {
                        rest = tempRest;
                        result = sumValue;
                    }

                    if (sumValue < target)
                    {
                        do
                        {
                            lo++;
                        } while (lo < hi && nums[lo - 1] == nums[lo]);
                    }
                    else if (sumValue > target)
                    {
                        do
                        {
                            hi--;
                        } while (lo < hi && nums[hi + 1] == nums[hi]);
                    }
                    else
                    {
                        do
                        {
                            lo++;
                        } while (lo < hi && nums[lo - 1] == nums[lo]);
                        do
                        {
                            hi--;
                        } while (lo < hi && nums[hi + 1] == nums[hi]);
                    }
                }

                while (index < nums.Length - 3 && nums[index + 1] == nums[index])
                {
                    index++;
                }
            }

            return result;
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
