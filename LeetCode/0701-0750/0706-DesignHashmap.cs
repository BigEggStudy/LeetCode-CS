//-----------------------------------------------------------------------------
// Runtime: 260ms
// Memory Usage: 47.4 MB
// Link: https://leetcode.com/submissions/detail/336971143/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0706_DesignHashmap
    {
        private const int size = 10000;
        private int[] keyTable;
        private int[] valTable;

        /** Initialize your data structure here. */
        public _0706_DesignHashmap()
        {
            keyTable = new int[size];
            valTable = new int[size];
            for (int i = 0; i < size; i++)
            {
                keyTable[i] = -1;
                valTable[i] = -1;
            }
        }

        /** value will always be non-negative. */
        public void Put(int key, int value)
        {
            var i = Hash(key);
            while (keyTable[i] != -1 && keyTable[i] != key)
            {
                if (i == size - 1)
                    i = 0;
                else
                    i++;
            }

            keyTable[i] = key;
            valTable[i] = value;
        }

        /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
        public int Get(int key)
        {
            var i = Hash(key);
            while (keyTable[i] != -1 && keyTable[i] != key)
            {
                if (i == size - 1)
                    i = 0;
                else
                    i++;
            }

            return valTable[i];
        }

        /** Removes the mapping of the specified value key if this map contains a mapping for the key */
        public void Remove(int key)
        {
            var i = Hash(key);
            while (keyTable[i] != -1 && keyTable[i] != key)
            {
                if (i == size - 1)
                    i = 0;
                else
                    i++;
            }

            // tombstone is -2.
            keyTable[i] = -2;
            valTable[i] = -2;
        }

        private int Hash(int key)
        {
            return key % size;
        }
    }

    /**
     * Your MyHashMap object will be instantiated and called as such:
     * MyHashMap obj = new MyHashMap();
     * obj.Put(key,value);
     * int param_2 = obj.Get(key);
     * obj.Remove(key);
     */
}
