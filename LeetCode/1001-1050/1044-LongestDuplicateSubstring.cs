//-----------------------------------------------------------------------------
// Runtime: 376ms
// Memory Usage: 45.1 MB
// Link: https://leetcode.com/submissions/detail/382318750/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _1044_LongestDuplicateSubstring
    {
        private const int ALPHABET = 26;
        private long modulus = (long)Math.Pow(2, 32);

        public string LongestDupSubstring(string S)
        {
            var n = S.Length;
            int left = 1, right = n;
            var result = string.Empty;
            while (left <= right)
            {
                var mid = left + (right - left) / 2;
                var start = Search(S.ToCharArray(), mid);
                if (start != -1)
                {
                    result = S.Substring(start, mid);
                    left = mid + 1;
                }
                else right = mid - 1;
            }

            return result;
        }

        private int Search(char[] chArray, int targetLength)
        {
            var n = chArray.Length;

            long h = 0;
            for (int i = 0; i < targetLength; i++)
                h = (h * ALPHABET + chArray[i] - 'a') % modulus;

            var seen = new HashSet<long>();
            seen.Add(h);

            long aL = 1;
            for (int i = 1; i <= targetLength; i++)
                aL = (aL * ALPHABET) % modulus;

            for (int start = 0; start < n - targetLength; start++)
            {
                h = (h * ALPHABET - (chArray[start] - 'a') * aL % modulus + modulus) % modulus;
                h = (h + chArray[start + targetLength] - 'a') % modulus;
                if (seen.Contains(h)) return start + 1;
                seen.Add(h);
            }

            return -1;
        }
    }
}
