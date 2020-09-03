//-----------------------------------------------------------------------------
// Runtime: 84ms
// Memory Usage: 23.9 MB
// Link: https://leetcode.com/submissions/detail/343393972/
//-----------------------------------------------------------------------------

using System.Text;

namespace LeetCode
{
    public class _1071_GreatestCommonDivisorOfStrings
    {
        public string GcdOfStrings(string str1, string str2)
        {
            if (str1 == str2) return str1;
            if (str1.Length > str2.Length) return GcdOfStrings(str2, str1);

            var i = 1;
            while (i <= str1.Length)
            {
                var length = str1.Length / i;
                if ((str1.Length % length == 0) && (str2.Length % length == 0))
                {
                    var sb1 = new StringBuilder();
                    var sb2 = new StringBuilder();

                    var result = str1.Substring(0, length);

                    var x1 = str1.Length / length;
                    for (int j = 0; j < x1; j++)
                        sb1.Append(result);
                    var x2 = str2.Length / length;
                    for (int j = 0; j < x2; j++)
                        sb2.Append(result);

                    if ((str1 == sb1.ToString()) && (str2 == sb2.ToString()))
                        return result;
                }
                i++;
            }

            return string.Empty;
        }
    }
}
