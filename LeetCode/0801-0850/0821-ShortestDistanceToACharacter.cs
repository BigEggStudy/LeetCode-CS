//-----------------------------------------------------------------------------
// Runtime: 224ms
// Memory Usage: 30.9 MB
// Link: https://leetcode.com/submissions/detail/331974846/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0821_ShortestDistanceToACharacter
    {
        public int[] ShortestToChar(string S, char C)
        {
            var result = new int[S.Length];

            var distance = S.Length;
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == C)
                {
                    result[i] = 0;
                    distance = 1;
                }
                else
                {
                    if (result[i] < distance)
                        result[i] = distance++;
                }
            }

            distance = S.Length;
            for (int i = S.Length - 1; i >= 0; i--)
            {
                if (S[i] == C)
                    distance = 1;
                else
                {
                    if (result[i] > distance)
                        result[i] = distance++;
                }
            }

            return result;
        }
    }
}
