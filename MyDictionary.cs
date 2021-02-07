using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class MyDictionary<T_Key,T_Value>
    {
        T_Key[] keys;
        T_Value[] values;

        public MyDictionary()
        {
            keys = new T_Key[0];
            values = new T_Value[0];

        }
        public void Add(T_Key key, T_Value value)
        {
            T_Key[] temp_Key = keys;
            T_Value[] temp_Values = values;
            keys = new T_Key[keys.Length + 1];
            values = new T_Value[values.Length + 1];
            for (int i = 0; i < temp_Key.Length; i++)
            {
                keys[i] = temp_Key[i];
                values[i] = temp_Values[i];
            }

            keys[temp_Key.Length] = key;
            values[temp_Values.Length] = value;

        }
        public int Length
        {
            get { return keys.Length; }
        }
    
      public void Listing()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("{0}--->{1}",keys[i],values[i]);
            }
        }
    }
}
