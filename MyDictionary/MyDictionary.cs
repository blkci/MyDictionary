using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<K,V>
    {
        K[] key;
        V[] value;

        public MyDictionary()
        {
            key = new K[0];
            value = new V[0];
        }

        public void Add(K k, V v)
        {
            K[] tempKey = key;
            V[] tempValue = value;
            key = new K[key.Length + 1];
            value = new V[value.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                key[i] = tempKey[i];
                value[i] = tempValue[i];
            }
            key[key.Length - 1] = k;
            value[value.Length - 1] = v;
           
        }
        public void print()
        {
            for (int i = 0; i < key.Length; i++)
            {
                Console.WriteLine(key[i] + ", " + value[i]);
                
            }
        }
    }
}
