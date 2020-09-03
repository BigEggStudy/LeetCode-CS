//-----------------------------------------------------------------------------
// Runtime: 72ms
// Memory Usage: 24.8 MB
// Link: https://leetcode.com/submissions/detail/342807812/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0171_ExcelSheetColumnNumber
    {
        public int TitleToNumber(string s)
        {
            var value = 0;
            foreach (var ch in s)
            {
                value *= 26;
                value += ch - 'A' + 1;
            }

            return value;
        }
    }
}
