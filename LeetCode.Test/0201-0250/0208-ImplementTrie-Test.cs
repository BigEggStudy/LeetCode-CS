using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0208_ImplementTrie_Test
    {
        [TestMethod]
        public void TrieTest()
        {
            var trie = new _0208_ImplementTrie();

            trie.Insert("apple");
            Assert.IsTrue(trie.Search("apple"));
            Assert.IsFalse(trie.Search("app"));
            Assert.IsTrue(trie.StartsWith("app"));
            trie.Insert("app");
            Assert.IsTrue(trie.Search("app"));
        }
    }
}
