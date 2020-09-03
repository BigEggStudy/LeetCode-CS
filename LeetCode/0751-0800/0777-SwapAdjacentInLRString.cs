//-----------------------------------------------------------------------------
// Runtime: 72ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0777_SwapAdjacentInLRString
    {
        public bool CanTransform(string start, string end)
        {
            var N = start.Length;

            var startIndex = -1;
            var endIndex = -1;
            while (++startIndex < N && ++endIndex < N)
            {
                while (startIndex < N && start[startIndex] == 'X') startIndex++;
                while (endIndex < N && end[endIndex] == 'X') endIndex++;

                if ((startIndex == N && endIndex < N) || (startIndex < N && endIndex == N))
                    return false;

                if (startIndex < N && endIndex < N)
                    if (start[startIndex] != end[endIndex] || (start[startIndex] == 'L' && startIndex < endIndex) || (start[startIndex] == 'R' && startIndex > endIndex))
                        return false;
            }
            return true;
        }
    }
}
