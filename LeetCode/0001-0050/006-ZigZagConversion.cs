//-----------------------------------------------------------------------------
// Runtime: 148ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _006_ZigZagConversion
    {
        public string Convert(string s, int numRows)
        {
            if (numRows <= 1 || s.Length <= 1) { return s; }

            var result = new char[s.Length];
            var index = 0;
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; (numRows * 2 - 2) * j + i < s.Length; j++)
                {
                    var originalIndex = (numRows * 2 - 2) * j + i;
                    result[index++] = s[originalIndex];

                    if (i == 0 || i == numRows - 1) { continue; }

                    originalIndex = originalIndex + (numRows * 2 - 2) - i * 2;
                    if (originalIndex < s.Length)
                    {
                        result[index++] = s[originalIndex];
                    }
                }
            }

            return new string(result);
        }
    }
}
