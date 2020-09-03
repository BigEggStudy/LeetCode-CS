//-----------------------------------------------------------------------------
// Runtime: 272ms
// Memory Usage: 48.6 MB
// Link: https://leetcode.com/submissions/detail/380046401/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0212_WordSearchII
    {
        public IList<string> FindWords(char[][] board, string[] words)
        {
            var result = new List<string>();
            var root = BuildTrie(words);
            var N = board.Length;
            var M = board[0].Length;

            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    BackTracking(board, i, j, N, M, root, result);

            return result;
        }

        private void BackTracking(char[][] board, int i, int j, int N, int M, TrieNode node, IList<string> results)
        {
            var ch = board[i][j];
            if (ch == '#' || node.Children[ch - 'a'] == null) return;
            node = node.Children[ch - 'a'];
            if (node.IsFinished)
            {
                results.Add(node.Word);
                node.IsFinished = false;
            }

            board[i][j] = '#';
            if (i > 0) BackTracking(board, i - 1, j, N, M, node, results);
            if (j > 0) BackTracking(board, i, j - 1, N, M, node, results);
            if (i < N - 1) BackTracking(board, i + 1, j, N, M, node, results);
            if (j < M - 1) BackTracking(board, i, j + 1, N, M, node, results);
            board[i][j] = ch;
        }

        private TrieNode BuildTrie(string[] words)
        {
            var root = new TrieNode();

            foreach (var word in words)
            {
                var currentNode = root;
                foreach (var ch in word)
                {
                    if (currentNode.Children[ch - 'a'] == null)
                        currentNode.Children[ch - 'a'] = new TrieNode();
                    currentNode = currentNode.Children[ch - 'a'];
                }
                currentNode.IsFinished = true;
                currentNode.Word = word;
            }

            return root;
        }

        public class TrieNode
        {
            public TrieNode[] Children { get; } = new TrieNode[26];
            public bool IsFinished { get; set; }
            public string Word { get; set; }
        }
    }
}
