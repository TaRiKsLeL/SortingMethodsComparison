using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortMathodsComparing.Sorts
{
    public class Selection : Sorter
    {
        public override void Sort<T>(T[] array)
        {

            int smallest;

            SetupTimer();
            //The algorithm builds the sorted list from the left.
            //1. For each item in the array...
            for (int i = 0; i < array.Length - 1; i++)
            {
                //2. ...assume the first item is the smallest value
                smallest = i;
                //3. Cycle through the rest of the array
                for (int j = i + 1; j < array.Length; j++)
                {
                    //4. If any of the remaining values are smaller, find the smallest of these
                    if (array[j].CompareTo(array[smallest])<0)
                    {
                        smallest = j;
                    }
                }
                //5. Swap the found-smallest value with the current value
                Foo.Swap<T>(ref array[smallest], ref array[i]);
            }

            stopwatch.Stop();
            GatherInfo(array);
        }
    }
}
