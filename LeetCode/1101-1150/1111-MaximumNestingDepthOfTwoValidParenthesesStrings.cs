//-----------------------------------------------------------------------------
// Runtime: 232ms
// Memory Usage: 33.4 MB
// Link: https://leetcode.com/submissions/detail/361636367/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1111_MaximumNestingDepthOfTwoValidParenthesesStrings
    {
        public int[] MaxDepthAfterSplit(string seq)
        {
            var result = new int[seq.Length];
            var currDepth = -1;

            for (var i = 0; i < seq.Length; i++)
            {
                if (seq[i] == '(')
                {
                    currDepth++;
                    result[i] = currDepth % 2;
                }
                else
                {
                    result[i] = currDepth % 2;
                    currDepth--;
                }
            }

            return result;
        }
    }
}
