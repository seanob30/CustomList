using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class CustomList<T> : IEnumerable
    {
        T[] contents;
        public int Capacity { get; set; }
        public int Count
        {
            get
            {
                int count = 0;
                if (contents != null)
                {
                    foreach (object item in contents)
                    {
                        count++;
                    }
                    return count;
                }
                else
                {
                    return 0;
                }
            }
        }
        public CustomList()
        {
            Capacity = 10;
            contents = new T[Capacity];
        }
        public void Add(T item)
        {
            if(Count >= Capacity)
            {
                T[] temp = new T[Capacity * 2];
                for(int i = 0; i < Count; i++)
                {
                    temp[i] = contents[i];
                }
                temp[Count] = item;
                contents = temp;
            }
            else
            {
                T[] temp = new T[Capacity];
                for (int i = 0; i < Count; i++)
                {
                    temp[i] = contents[i];
                }
                temp[Count] = item;
                contents = temp;
            } 
        }
        public bool RemoveAt(T item)
        {

        }
        public void Insert(int index, T item)
        {

        }
        public static CustomList<T> operator +(CustomList<T> list1, CustomList<T> list2)
        {

        }
        public static CustomList<T> operator -(CustomList<T> list1, CustomList<T> list2)
        {

        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < contents.Length; i++)
            {
                yield return contents[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
