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
        private T[] array;

        public CustomList()
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];
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
            items = new T[4];
            array = new T[8];
            for (int i = 0; i < items.Length; i++)
            {
                array[i] = items[i];
            }
        }




       
        
    
    
    
    
    }
}
