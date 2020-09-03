//-----------------------------------------------------------------------------
// Runtime: 72ms
// Memory Usage: 22.7 MB
// Link: https://leetcode.com/submissions/detail/327826280/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1374_GenerateAStringWithCharactersThatHaveOddCounts
    {
        public string GenerateTheString(int n)
        {
            return n % 2 == 1 ?
                new string('a', n) :
                new string('a', n - 1) + 'b';
        }
    }
}
