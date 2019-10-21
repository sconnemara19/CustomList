using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Class_Clone
{
    public class CustomList<T>: IEnumerable
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
            get
            {
                if (i >= 0 && i < count)
                {
                    throw new IndexOutOfRangeException();
                }
                
                return items[i]; 
            
            }
            
            set 
            {

                if (i < 0 || i >= count)
                {
                    throw new IndexOutOfRangeException();
                }


                    items[i] = value; 
            }
        }
        public int Count
        {
            get
            {
                return count;
            }
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
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
            bool found = false;
            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(itemToRemove))
                {


                    found = true;
                     
                }
                if(found == true)
                {
                    items[i] = items[i + 1];
                }

            }
   
        }
        public override string ToString()
        {
            string result = "";   
            for (int i = 0; i < count; i++)
            {
             result += items[i].ToString();
                
            }
            return result;
        }
        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
            CustomList<T> result = new CustomList<T>();
            for (int i = 0; i < firstList.Count; i++)
            {
                result.Add(firstList[i]);
            }
            for (int i = 0; i < secondList.Count; i++)
            {
                result.Add(secondList[i]);
            }
            return result;
        }
        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            for (int i = 0; i < firstList.Count; i++)
            {
                firstList.Remove(secondList[i]);
            }
            return firstList;
        }
        public CustomList<T> Zip(CustomList<T> firstList, CustomList<T> secondList)
        {
            CustomList<T> result = new CustomList<T>();
            for (int i = 0; i < Count; i++)
            {
                result.Add(firstList[i]);
                result.Add(secondList[i]);
            }
            return result;
        }

        public IEnumerator GetEnumerator()
        {

        }










    }
}

