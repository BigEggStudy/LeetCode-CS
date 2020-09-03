//-----------------------------------------------------------------------------
// Runtime: 300ms
// Memory Usage: 34.9 MB
// Link: https://leetcode.com/submissions/detail/365341536/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _0588_DesignInMemoryFileSystem
    {
        private readonly FileNode root;

        public _0588_DesignInMemoryFileSystem()
        {
            root = new FileNode("");
        }

        public IList<string> Ls(string path)
        {
            return FindNode(path).GetList();
        }

        public void Mkdir(string path)
        {
            FindNode(path);
        }

        public void AddContentToFile(string filePath, string content)
        {
            FindNode(filePath).AddContent(content);
        }

        public string ReadContentFromFile(string filePath)
        {
            return FindNode(filePath).Content;
        }

        private FileNode FindNode(string path)
        {
            var levels = path.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

            var curr = root;
            foreach (var level in levels)
            {
                if (level.Length == 0) continue;

                if (!curr.Children.ContainsKey(level))
                    curr.Children[level] = new FileNode(level);
                curr = curr.Children[level];

                if (curr.IsFile) break;
            }

            return curr;
        }

        private class FileNode
        {
            private readonly SortedDictionary<string, FileNode> children;
            private readonly StringBuilder file;

            public FileNode(string name)
            {
                children = new SortedDictionary<string, FileNode>();
                file = new StringBuilder();
                Name = name;
            }

            public string Name { get; }

            public IDictionary<string, FileNode> Children => children;

            public string Content => file.ToString();

            public void AddContent(string content) => file.Append(content);

            public bool IsFile => file.Length > 0;

            public List<string> GetList()
            {
                var list = new List<string>(); ;
                if (IsFile)
                    list.Add(Name);
                else
                    list.AddRange(children.Keys);

                return list;
            }
        }
    }

    /**
     * Your FileSystem object will be instantiated and called as such:
     * FileSystem obj = new FileSystem();
     * IList<string> param_1 = obj.Ls(path);
     * obj.Mkdir(path);
     * obj.AddContentToFile(filePath,content);
     * string param_4 = obj.ReadContentFromFile(filePath);
     */
}
