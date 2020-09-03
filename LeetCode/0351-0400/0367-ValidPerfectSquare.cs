//-----------------------------------------------------------------------------
// Runtime: 40ms
// Memory Usage: 14.4 MB
// Link: https://leetcode.com/submissions/detail/336921917/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0367_ValidPerfectSquare
    {
        public bool IsPerfectSquare(int num)
        {
            if (num < 2) return true;

            int left = 2, right = num / 2;
            long mid, square;
            while (left <= right)
            {
                mid = left + (right - left) / 2;
                square = mid * mid;
                if (square == num) return true;
                else if (square > num)
                    right = (int)mid - 1;
                else
                    left = (int)mid + 1;
            }
            return false;
        }
    }
}
