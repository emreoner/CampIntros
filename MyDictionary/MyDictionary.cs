using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaries
{
    public class MyDictionary<TKey, TVal>
    {
        TKey[] keys;
        TVal[] vals;
        TKey[] tempKeys;
        TVal[] tempVals;
        public MyDictionary()
        {
            keys = new TKey[0];
            vals = new TVal[0];
        }

        public void Add(TKey key, TVal val)
        {

            tempKeys = keys;
            tempVals = vals;
            if (keys.Length > 0)
            {
                for (int i = 0; i < keys.Length; i++)
                {
                    if (keys[i].Equals(key))
                        throw new ArgumentException("An item with the same key has already been added. Key: " + key.ToString());
                }
            }
            keys = new TKey[keys.Length + 1];
            vals = new TVal[keys.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                vals[i] = tempVals[i];
            }
            keys[keys.Length - 1] = key;
            vals[keys.Length - 1] = val;

        }

    }
}
