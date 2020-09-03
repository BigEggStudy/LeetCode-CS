//-----------------------------------------------------------------------------
// Runtime: 76ms
// Memory Usage: 22.7 MB
// Link: https://leetcode.com/submissions/detail/338618000/
//-----------------------------------------------------------------------------

using System.Text;

namespace LeetCode
{
    public class _0917_ReverseOnlyLetters
    {
        public string ReverseOnlyLetters(string S)
        {
            var sb = new StringBuilder();

            var j = S.Length - 1;
            for (int i = 0; i < S.Length; i++)
            {
                if (char.IsLetter(S[i]))
                {
                    while (!char.IsLetter(S[j]))
                        j--;

                    sb.Append(S[j--]);
                }
                else
                    sb.Append(S[i]);
            }

            return sb.ToString();
        }
    }
}
