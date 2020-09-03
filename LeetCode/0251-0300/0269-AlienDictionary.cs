//-----------------------------------------------------------------------------
// Runtime: 100ms
// Memory Usage: 24.3 MB
// Link: https://leetcode.com/submissions/detail/380527777/
//-----------------------------------------------------------------------------

using System.Text;

namespace LeetCode
{
    public class _0269_AlienDictionary
    {
        public string AlienOrder(string[] words)
        {
            var adj = new bool[26, 26];
            var visited = new int[26];
            //  Array.Fill(visited, int.MinValue);
            for (int i = 0; i < 26; i++)
                visited[i] = int.MinValue;

            if (!BuildGraph(words, adj, visited))
                return string.Empty;

            var result = new StringBuilder(26);
            for (int i = 0; i < 26; i++)
                if (visited[i] == 0 && !DFS(adj, visited, i, result))
                    return string.Empty;

            return result.ToString();
        }

        private bool DFS(bool[,] adj, int[] visited, int index, StringBuilder sb)
        {
            visited[index] = 1;

            for (int j = 0; j < 26; j++)
                if (adj[index, j])
                {
                    if (visited[j] == 1) return false;
                    if (visited[j] == 0)
                        if (!DFS(adj, visited, j, sb))
                            return false;
                }

            visited[index] = 2;
            sb.Insert(0, (char)('a' + index));
            return true;
        }

        private bool BuildGraph(string[] words, bool[,] adj, int[] visited)
        {
            for (int i = 0; i < words.Length; i++)
            {
                var word = words[i];
                foreach (var ch in word)
                    visited[ch - 'a'] = 0;
                if (i == 0) continue;

                var prevWord = words[i - 1];
                for (int j = 0; j < prevWord.Length; j++)
                {
                    if (j >= word.Length) return false;

                    char ch = word[j], prevWordCh = prevWord[j];
                    if (ch != prevWordCh)
                    {
                        adj[prevWordCh - 'a', ch - 'a'] = true;
                        break;
                    }
                }
            }

            return true;
        }
    }
}
