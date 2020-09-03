//-----------------------------------------------------------------------------
// Runtime: 68ms
// Memory Usage: 21.9 MB
// Link: https://leetcode.com/submissions/detail/360459629/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1079_LetterTilePossibilities
    {
        public int NumTilePossibilities(string tiles)
        {
            var counts = new int[26];
            foreach (var ch in tiles)
                counts[ch - 'A']++;

            return DFS(counts);
        }

        private int DFS(int[] counts)
        {
            var sum = 0;
            for (int i = 0; i < 26; i++)
            {
                if (counts[i] == 0) continue;

                sum++;
                counts[i]--;
                sum += DFS(counts);
                counts[i]++;
            }

            return sum;
        }
    }
}
