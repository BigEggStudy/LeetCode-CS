//-----------------------------------------------------------------------------
// Runtime: 140ms
// Memory Usage: 36.4 MB
// Link: https://leetcode.com/submissions/detail/342547919/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1013_PartitionArrayIntoThreePartsWithEqualSum
    {
        public bool CanThreePartsEqualSum(int[] A)
        {
            var sum = 0;
            foreach (var num in A)
                sum += num;

            if (sum % 3 != 0) return false;

            var target = sum / 3;
            var count = 0;
            var currentSum = 0;
            foreach (var num in A)
            {
                currentSum += num;
                if (currentSum == target)
                {
                    count++;
                    currentSum = 0;
                }
            }

            return count > 2;
        }
    }
}
