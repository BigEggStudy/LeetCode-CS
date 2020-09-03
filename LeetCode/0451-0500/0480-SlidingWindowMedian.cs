//-----------------------------------------------------------------------------
// Runtime: 648ms
// Memory Usage: 37.6 MB
// Link: https://leetcode.com/submissions/detail/366236847/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _0480_SlidingWindowMedian
    {
        public double[] MedianSlidingWindow(int[] nums, int k)
        {
            // SortedDictionary.Keys.First() is must faster than SortedDictionary.Keys.Last() (terraible implementation of .net)
            var left = new SortedDictionary<long, int>(Comparer<long>.Create((x, y) => y.CompareTo(x)));
            var leftCount = 0;
            var right = new SortedDictionary<long, int>();
            var rightCount = 0;

            var result = new List<double>(nums.Length - k + 1);
            for (int i = 0; i < nums.Length; i++)
            {
                if (i >= k)
                {
                    if (rightCount > leftCount) result.Add(right.Keys.First());
                    else result.Add((right.Keys.First() + left.Keys.First()) / 2.0);

                    if (right.ContainsKey(nums[i - k]))
                    {
                        right[nums[i - k]]--;
                        if (right[nums[i - k]] == 0) right.Remove(nums[i - k]);
                        rightCount--;
                    }
                    else if (left.ContainsKey(nums[i - k]))
                    {
                        left[nums[i - k]]--;
                        if (left[nums[i - k]] == 0) left.Remove(nums[i - k]);
                        leftCount--;
                    }
                }

                if (!right.ContainsKey(nums[i]))
                    right[nums[i]] = 1;
                else
                    right[nums[i]]++;
                rightCount++;

                var minRight = right.Keys.First();
                right[minRight]--;
                if (right[minRight] == 0) right.Remove(minRight);
                rightCount--;
                if (!left.ContainsKey(minRight))
                    left[minRight] = 1;
                else
                    left[minRight]++;
                leftCount++;

                if (rightCount < leftCount)
                {
                    var maxLeft = left.Keys.First();
                    left[maxLeft]--;
                    if (left[maxLeft] == 0) left.Remove(maxLeft);
                    leftCount--;
                    if (!right.ContainsKey(maxLeft))
                        right[maxLeft] = 1;
                    else
                        right[maxLeft]++;
                    rightCount++;
                }
            }

            if (rightCount > leftCount) result.Add(right.Keys.First());
            else result.Add((right.Keys.First() + left.Keys.First()) / 2.0);

            return result.ToArray();
        }
    }
}
