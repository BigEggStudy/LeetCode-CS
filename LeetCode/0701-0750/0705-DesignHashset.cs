//-----------------------------------------------------------------------------
// Runtime: 228ms
// Memory Usage: 49.1 MB
// Link: https://leetcode.com/submissions/detail/337002075/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0705_DesignHashset
    {
        private bool[] flags = new bool[1000001];

        /** Initialize your data structure here. */
        public _0705_DesignHashset()
        {

        }

        public void Add(int key)
        {
            flags[key] = true;
        }

        public void Remove(int key)
        {
            flags[key] = false;
        }

        /** Returns true if this set contains the specified element */
        public bool Contains(int key)
        {
            return flags[key];
        }
    }

    /**
     * Your MyHashSet object will be instantiated and called as such:
     * MyHashSet obj = new MyHashSet();
     * obj.Add(key);
     * obj.Remove(key);
     * bool param_3 = obj.Contains(key);
     */
}
