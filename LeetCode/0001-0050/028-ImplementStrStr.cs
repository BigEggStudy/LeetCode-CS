//-----------------------------------------------------------------------------
// Runtime: 80ms
// Memory Usage: 20.6 MB
// Link: https://leetcode.com/submissions/detail/243054910/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _028_ImplementStrStr
    {
        public int StrStr(string haystack, string needle)
        {
            var needleLength = needle.Length;
            if (needleLength == 0) { return 0; }

            var loopLenght = haystack.Length - needleLength + 1;
            var needleIndex = 0;
            var n = 0;
            for (int i = 0; i < loopLenght; i++)
            {
                needleIndex = n = 0;
                while (needleIndex < needleLength
                    && haystack[i + needleIndex] == needle[needleIndex])
                {
                    if (n == 0 && needle[needleIndex] == needle[0])
                    {
                        n = needleIndex;
                    }
                    needleIndex++;
                }
                if (needleIndex == needleLength)
                {
                    return i;
                }
                if (n > 0) i += n - 1;
            }

            return -1;
        }
    }
}
