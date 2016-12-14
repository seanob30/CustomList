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
        public int Capacity { get { return capacity; } set { capacity = value; } } 
        public int Count { get { return count; } set {count = value; } }
        public T this[int i]
        {
            get
            {
                return contents[i];
            }
            set
            {
                contents[i] = value;
            }
        }
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
                T[] temporary = new T[capacity = capacity * 2];
                for(int i = 0; i < count; i++)
                {
                    temporary[i] = contents[i];
                }
                temporary[count] = item;
                contents = temporary;
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
        public void InsertAt(int index, T item)
        {
            if (count >= capacity)
            {
                T[] temporary = new T[capacity = capacity * 2];
                for (int i = 0; i < count; i++)
                {
                    temporary[i] = contents[i];
                }
                temporary[index] = item;
                contents = temporary;
                count++;
            }
            else
            {
                contents[index] = item;
                count++;
            }
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
            Count--;
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
        public static CustomList<T> operator +(CustomList<T> list1, CustomList<T> list2)
        {
            T[] temporary = new T[list1.Capacity + list2.Capacity];
            CustomList<T> newList = new CustomList<T>();
            newList.contents = temporary;
            for (int i = 0; i < list1.Count; i++)
            {
                newList.InsertAt(i, list1[i]);
            }
            for (int i = list1.Count; i < list1.count + list2.Count; i++)
            {
                newList.InsertAt(i,list2[i - list1.Count]);
            }
            return newList;
        }
        public static CustomList<T> operator -(CustomList<T> list1, CustomList<T> list2)
        {
            T[] temporary = new T[list1.Capacity];
            CustomList<T> newList = new CustomList<T>();
            newList.contents = temporary;
            for (int i = 0; i < list1.Count; i++)
            {
                newList.InsertAt(i, list1[i]);
            }
            for (int i = 0; i < newList.Count; i++)
            {
                if (newList[i].Equals(list2[i]))
                {
                    newList.RemoveAt(i);
                }
            }
            return newList;
        }
        public override string ToString()
        {
            string conversion = string.Empty;
            foreach (T item in contents)
            {
                if (string.IsNullOrEmpty(conversion))
                { conversion += item.ToString(); }
                else
                { conversion += string.Format(", {0}", item); }
            }
            return conversion;
        }
        public void Display()
        {
            foreach (T item in contents)
            {
                Console.WriteLine(item);
            }
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
