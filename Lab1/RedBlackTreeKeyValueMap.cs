using System.Collections.Generic;
using DSA.DataStructures.Trees;

namespace Lab1
{
    internal class RedBlackTreeKeyValueMap<TKey, TValue> : IKeyValueMap<TKey, TValue>
    {
        private RedBlackTreeMap<TKey, TValue> redblackTreeMap = new RedBlackTreeMap<TKey, TValue>();

        public RedBlackTreeKeyValueMap()
        {
        }

        public int Height => redblackTreeMap.Height;

        public int Count => redblackTreeMap.Count;

        public void Add(TKey key, TValue value)
        {
            redblackTreeMap.Add(key, value);
        }

        public KeyValuePair<TKey, TValue> Get(TKey key)
        {
            var value = redblackTreeMap[key];
            return new KeyValuePair<TKey, TValue>(key, value);
        }

        public bool Remove(TKey key)
        {
            if (redblackTreeMap.ContainsKey(key))
            {
                redblackTreeMap.Remove(key);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}