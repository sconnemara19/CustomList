using System;
using System.Collections;
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
            T item;
            CustomList < T > thirdList = new CustomList<T>();
            for (int i = 0; i < firstList.Count; i++)
            {
                for (int x = 0; x < secondList.Count; x++)
                {
                    if (firstList[i].Equals(secondList[x]))
                    {
                        item = firstList[i];
                        firstList.Remove(item);
                        secondList.Remove(item);
                        i = 0;
                        x = 0;



                    }
                    else
                    {
                        continue;
                    }

                }
            }
            thirdList = firstList + secondList;
            return thirdList;


            
        }
        public CustomList<T> Zip(CustomList<T> List)
        {
            CustomList<T> result = new CustomList<T>();
            for (int i = 0; i < Count; i++)
            {
                result.Add(items[i]);
                result.Add(List[i]);
            }
            return result;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return items[i];
            }
            

        }










    }
}

