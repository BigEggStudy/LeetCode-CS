//-----------------------------------------------------------------------------
// Runtime: 116ms
// Memory Usage: 28.1 MB
// Link: https://leetcode.com/submissions/detail/352390768/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0744_FindSmallestLetterGreaterThanTarget
    {
        public char NextGreatestLetter(char[] letters, char target)
        {
            int lo = 0, hi = letters.Length - 1;
            while (lo <= hi)
            {
                var mid = lo + (hi - lo) / 2;
                if (letters[mid] <= target) lo = mid + 1;
                else hi = mid - 1;
            }

            return letters[lo % letters.Length];
        }
    }
}
