//-----------------------------------------------------------------------------
// Runtime: 244ms
// Memory Usage: 30.3 MB
// Link: https://leetcode.com/submissions/detail/378577412/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _068_TextJustification
    {
        public IList<string> FullJustify(string[] words, int maxWidth)
        {
            var result = new List<string>();

            int start = 0, len = 0;
            var builder = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                if (len + words[i].Length > maxWidth)
                {
                    var space = maxWidth - len + (i - start);
                    builder.Clear();
                    for (int j = start; j < i; j++)
                    {
                        builder.Append(words[j]);

                        var tempSpace = j != i - 1
                            ? space / (i - start - 1) + ((j - start < (space % (i - start - 1))) ? 1 : 0)
                            : maxWidth - builder.Length;
                        builder.Append(new string(' ', tempSpace));
                    }
                    result.Add(builder.ToString());

                    len = 0;
                    start = i;
                }

                len += words[i].Length + 1;
            }

            builder.Clear();
            for (int j = start; j < words.Length; j++)
            {
                builder.Append(words[j]);
                var tempSpace = j != words.Length - 1
                    ? 1
                    : maxWidth - builder.Length;
                builder.Append(new string(' ', tempSpace));
            }
            result.Add(builder.ToString());

            return result;
        }
    }
}
