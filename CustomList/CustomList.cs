using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable
    {
        T[] contents;
        private int capacity;
        private int count;
        public int Capacity { get { return capacity; } set {; } } 
        public int Count { get { return count; } set {; } }
        public CustomList()
        {
            count = 0;
            capacity = 10;
            contents = new T[capacity];
        }
        public void Add(T item)
        {
            if(count >= capacity)
            {
                T[] temp = new T[capacity = capacity * 2];
                for(int i = 0; i < count; i++)
                {
                    temp[i] = contents[i];
                }
                temp[count] = item;
                contents = temp;
                count++;
            }
            else
            {
                T[] temp = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    temp[i] = contents[i];
                }
                temp[count] = item;
                contents = temp;
                count++;
            } 
        }
        public void Insert(int index, T item)
        {
            contents[index] = item;
        }
        public object ReadIndex(int index)
        {
            object item;
            item = contents[index];
            return item;
        }
        public int IndexOf(T item)
        {
            int index = -1;
            for (int i = 0; i < capacity; i++)
            {
                if (contents[i].Equals(item))
                {
                    index = i;
                }
            }
            return index;
        }
        public void RemoveAt(int index)
        {
            contents[index] = default(T);
        }
        public bool Remove(T item)
        {
            try
            {
                int index = IndexOf(item);
                RemoveAt(index);
                return true;
            }
            catch { return false; }
        }
        //public static CustomList<T> operator +(CustomList<T> list1, CustomList<T> list2)
        //{
        //}
        //public static CustomList<T> operator -(CustomList<T> list1, CustomList<T> list2)
        //{
        //}
        public override string ToString()
        {
            return base.ToString();
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
