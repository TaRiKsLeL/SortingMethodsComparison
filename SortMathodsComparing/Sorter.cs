using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortMathodsComparing
{
    class Sorter<T>
    {
        SortInfo LastSortInfo { get; set; }
        T[] LastSortedArray { get; set; }

        public Sorter()
        {
            LastSortInfo = new SortInfo();
            if (typeof(T) == typeof(int)) { LastSortInfo.DataType = DataType.INT_ARRAY; }
            else if (typeof(T) == typeof(string)) { LastSortInfo.DataType = DataType.STRING_ARRAY; }
        }

        public void bubbleSort(T[] array)
        {
            



        }
    }
}
