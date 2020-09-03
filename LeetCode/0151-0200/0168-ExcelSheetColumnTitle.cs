//-----------------------------------------------------------------------------
// Runtime: 68ms
// Memory Usage: 22.3 MB
// Link: https://leetcode.com/submissions/detail/359596282/
//-----------------------------------------------------------------------------

using System.Text;

namespace LeetCode
{
    public class _0168_ExcelSheetColumnTitle
    {
        public string ConvertToTitle(int n)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var sb = new StringBuilder();
            while (n > 0)
            {
                n--;

                var d = n % 26;
                sb.Insert(0, chars[d]);
                n /= 26;
            }

            return sb.ToString();
        }
    }
}
