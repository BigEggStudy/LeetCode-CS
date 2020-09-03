//-----------------------------------------------------------------------------
// Runtime: 244ms
// Memory Usage: 31.1 MB
// Link: https://leetcode.com/submissions/detail/343620812/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0167_TwoSumII
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int i = 0, j = numbers.Length - 1;
            while (i < j)
            {
                int compare = (numbers[i] + numbers[j]).CompareTo(target);
                if (compare == 0) return new int[] { i + 1, j + 1 };
                else if (compare > 0) j--;
                else if (compare < 0) i++;
            }

            return new int[] { };
        }
    }
}
