using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Class_Clone
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> test = new CustomList<int>();
            test.Add(82);
            test.Add(92);
            test.Add(100);
            test.Add(19);
            test.Add(9);

        }
    }
}
