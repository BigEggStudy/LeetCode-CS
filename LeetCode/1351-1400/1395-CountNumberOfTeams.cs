//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 23.9 MB
// Link: https://leetcode.com/submissions/detail/360421345/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1395_CountNumberOfTeams
    {
        public int NumTeams(int[] rating)
        {
            var result = 0;
            for (int i = 1; i < rating.Length - 1; i++)
            {
                int leftLess = 0, leftGreater = 0;
                for (int j = 0; j < i; j++)
                {
                    if (rating[j] > rating[i]) leftGreater++;
                    if (rating[j] < rating[i]) leftLess++;
                }

                int rightLess = 0, rightGreater = 0;
                for (int j = i + 1; j < rating.Length; j++)
                {
                    if (rating[j] > rating[i]) rightGreater++;
                    if (rating[j] < rating[i]) rightLess++;
                }

                result += leftLess * rightGreater + leftGreater * rightLess;
            }

            return result;
        }
    }
}
