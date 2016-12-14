using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> list1 = new CustomList<int>();
            list1.Add(23);
            list1.Add(30);
            list1.Add(35);
            list1.Add(23);
            list1.Add(30);
            list1.Add(35);
            CustomList<int> list2 = new CustomList<int>();
            list2.Add(23);
            list2.Add(30);
            list2.Add(35);
            list2.Add(27);
            list2.Add(99);
            list2.Add(88);

            CustomList<int> newList = list1 - list2;
            newList.Display();
            Console.ReadKey();
        }
    }
}
