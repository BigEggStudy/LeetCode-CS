//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 24.8 MB
// Link: https://leetcode.com/submissions/detail/361280439/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1415_TheKThLexicographicalStringOfAllHappyStringsOfLengthN
    {
        private string result = string.Empty;
        private int count = 0;

        public string GetHappyString(int n, int k)
        {
            DFS("", n, k, ' ');
            return result;
        }

        private void DFS(string currentStr, int n, int k, char prev)
        {
            if (currentStr.Length == n)
            {
                count++;
                if (count == k)
                    result = currentStr;
                return;
            }

            for (char ch = 'a'; ch <= 'c'; ch++)
            {
                if (currentStr.Length > 0 && prev == ch)
                    continue;

                if (string.IsNullOrEmpty(result))
                    DFS(currentStr + ch, n, k, ch);
            }
        }
    }
}
