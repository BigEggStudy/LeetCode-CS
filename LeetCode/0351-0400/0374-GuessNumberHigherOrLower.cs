//-----------------------------------------------------------------------------
// Runtime: 40ms
// Memory Usage: 14.5 MB
// Link: https://leetcode.com/submissions/detail/352819183/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    /**
     * Forward declaration of guess API.
     * @param  num   your guess
     * @return 	     -1 if num is lower than the guess number
     *			      1 if num is higher than the guess number
     *               otherwise return 0
     * int guess(int num);
     */

    public class _0374_GuessNumberHigherOrLower
    {
        private readonly int number;

        public _0374_GuessNumberHigherOrLower(int number)
        {
            this.number = number;
        }

        public int GuessNumber(int n)
        {
            int lo = 1, hi = n;
            while (lo <= hi)
            {
                var mid = lo + (hi - lo) / 2;

                var compare = guess(mid);
                if (compare == 0) return mid;
                else if (compare == -1) hi = mid - 1;
                else lo = mid + 1;
            }

            return -1;
        }

        private int guess(int num)
        {
            if (num < number) return 1;
            else if (num > number) return -1;
            else return 0;
        }
    }
}
