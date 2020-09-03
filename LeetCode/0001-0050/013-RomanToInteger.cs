//-----------------------------------------------------------------------------
// Runtime: 84ms
// Memory Usage: 25.7 MB
// Link: https://leetcode.com/submissions/detail/342506469/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _013_RomanToInteger
    {
        int Mapping(char ch)
        {
            switch (ch)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
                default: return 0;
            }
        }

        public int RomanToInt(string s)
        {
            var result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i > 0 && Mapping(s[i]) > Mapping(s[i - 1]))
                {
                    result += Mapping(s[i]) - Mapping(s[i - 1]) * 2;
                }
                else
                {
                    result += Mapping(s[i]);
                }
            }

            return result;
        }
    }
}
