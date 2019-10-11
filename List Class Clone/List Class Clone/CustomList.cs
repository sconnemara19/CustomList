using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Class_Clone
{
    public class CustomList<T>
    {
        private T[] items;
        private int count;
        private int capacity;

        public CustomList()
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];


        }

        public T this[int i]
        {
            get { return items[i]; }
            set { items[i] = value; }
        }
        public int Count
        {
            get
            {
                return count;
            }
        }






        public void Add(T itemToAdd)
        {
            items[count] = itemToAdd;
            count++;
            if (count == capacity)
            {
                IncreaseCapcity();

            }


        }
        public void IncreaseCapcity()
        {
            capacity = capacity * 2;

            T[] array = new T[capacity];
            for (int i = 0; i < items.Length; i++)
            {
                array[i] = items[i];
            }
            items = array;
        }
        public void Remove(T itemToRemove)
        {
            T[] temp = new T[capacity];
            int j = 0;
            for (int i = 0; i < count; i++)
            {
                if (!items[i].Equals(itemToRemove))
                {
                    
                    
                    items[i] = temp[j];
                    j++;
                }
                else if (items[i].Equals(itemToRemove))
                {
                    count--;

                }

                items = temp;
                

            }



            //}
            //public override string ToString() { }









        }
    }
}
