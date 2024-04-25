using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CollectionsTask
{
    internal class ArrayList
    {
        public int Capacity { get; set; }

        public object[] data;

        public int Count { get; set; }

        public ArrayList(int capacity)
        {
            Capacity = capacity;
            Count = 0;
            data = new object[Capacity];
        }

        public ArrayList()
        {
        }

        public void Add(object item)
        {
            if(Count == Capacity)
            {
                int NewCapacity = Capacity * 2;
                object[] newData = new object[NewCapacity];
                Array.Copy(data, newData, data.Length);
                data = newData;
                Capacity = NewCapacity;
            }
            data[Count] = item;
            Count ++;
        }
         public bool Remove(object item)
    {
        int index = Array.IndexOf(data, item, 0, Count);
        if (index >= 0)
        {
            //RemoveAt(index);
            return true;
        }
        return false;
    }
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
            {
                Console.WriteLine("Index is out of range.");
            }

            for (int i = index; i < Count - 1; i++)
            {
                data[i] = data[i + 1];
            }

            Count--;
        }
    }
}
