//-----------------------------------------------------------------------------
// Runtime: 232ms
// Memory Usage: 30.9 MB
// Link: https://leetcode.com/submissions/detail/367603448/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _0722_RemoveComments
    {
        public IList<string> RemoveComments(string[] source)
        {
            var inCommentBlock = false;
            var sb = new StringBuilder();
            var result = new List<string>();

            foreach (var line in source)
            {
                if (!inCommentBlock && sb.Length > 0) sb.Clear();
                for (int i = 0; i < line.Length; i++)
                {
                    if (inCommentBlock)
                    {
                        if (i + 1 < line.Length && line[i] == '*' && line[i + 1] == '/')
                        {
                            inCommentBlock = false;
                            i++;
                        }
                        continue;
                    }


                    if (i + 1 < line.Length)
                        if (line[i] == '/' && line[i + 1] == '/') break;
                        else if (line[i] == '/' && line[i + 1] == '*')
                        {
                            inCommentBlock = true;
                            i++;
                            continue;
                        }

                    sb.Append(line[i]);
                }

                if (!inCommentBlock && sb.Length > 0)
                    result.Add(sb.ToString());
            }

            return result;
        }
    }
}
