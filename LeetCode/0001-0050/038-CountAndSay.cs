//-----------------------------------------------------------------------------
// Runtime: 80ms
// Memory Usage: 22.8 MB
// Link: https://leetcode.com/submissions/detail/352429668/
//-----------------------------------------------------------------------------

using System.Text;

namespace LeetCode
{
    public class _038_CountAndSay
    {
        public string CountAndSay(int n)
        {
            var result = "1";
            char currentCh;
            int i, j, startNum;
            var builder = new StringBuilder();

            for (i = 1; i < n; i++)
            {
                currentCh = result[0];
                startNum = 0;
                for (j = 1; j < result.Length; j++)
                {
                    if (currentCh != result[j])
                    {
                        builder.Append(j - startNum);
                        builder.Append(currentCh);
                        currentCh = result[j];
                        startNum = j;
                    }
                }
                builder.Append(j - startNum);
                builder.Append(currentCh);

                result = builder.ToString();
                builder.Clear();
            }

            return result;
        }
    }
}
