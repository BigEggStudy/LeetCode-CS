//-----------------------------------------------------------------------------
// Runtime: 104ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System.Linq;
using System.Text;

namespace LeetCode
{
    public class _0833_FindAndReplaceInString
    {
        public string FindReplaceString(string S, int[] indexes, string[] sources, string[] targets)
        {
            var N = S.Length;
            var match = new int[N];
            for (int i = 0; i < N; i++)
                match[i] = -1;

            for (int i = 0; i < indexes.Length; i++)
                if (S.Substring(indexes[i], sources[i].Length).SequenceEqual(sources[i]))
                    match[indexes[i]] = i;

            var sb = new StringBuilder();
            var index = 0;
            while (index < N)
            {
                if (match[index] > -1)
                {
                    sb.Append(targets[match[index]]);
                    index += sources[match[index]].Length;
                }
                else
                {
                    sb.Append(S[index++]);
                }
            }

            return sb.ToString();
        }
    }
}
