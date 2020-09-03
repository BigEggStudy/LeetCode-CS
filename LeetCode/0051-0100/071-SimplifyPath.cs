//-----------------------------------------------------------------------------
// Runtime: 132ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System;
using System.Text;

namespace LeetCode
{
    public class _071_SimplifyPath
    {
        public string SimplifyPath(string path)
        {
            if (string.IsNullOrEmpty(path)) { return "/"; }

            var folders = path.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            var folder = string.Empty;
            var builder = new StringBuilder();
            var ignore = 0;
            for (int i = folders.Length - 1; i >= 0; i--)
            {
                folder = folders[i];

                if (folder.Equals(".")) { continue; }
                if (folder.Equals("..")) { ignore++; continue; }
                if (ignore > 0) { ignore--; continue; }

                builder.Insert(0, folder);
                builder.Insert(0, "/");
            }

            return builder.Length > 0 ? builder.ToString() : "/";
        }
    }
}
