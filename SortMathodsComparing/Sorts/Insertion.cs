using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortMathodsComparing.Sorts
{
    public class Insertion : Sorter
    {
        public Insertion() : base()
        {
            LastSortInfo.SortType = SortType.INSERTION;
        }

        public override void Sort<T>(T[] array)
        {
            SetupTimer();

            //1. For each value in the array...
            for (int i = 1; i < array.Length; ++i)
            {
                //2. Store the current value in a variable.
                T currentValue = array[i];
                int pointer = i - 1;

                //3. While we are pointing to a valid value...
                //4. If the current value is less than the value we are pointing at...
                while (pointer >= 0 && (array[pointer].CompareTo(currentValue)>0))
                {
                    //5. Then move the pointed-at value up one space, and store the
                    //   current value at the pointed-at position.
                    array[pointer + 1] = array[pointer];
                    pointer = pointer - 1;
                }
                array[pointer + 1] = currentValue;
            }

            stopwatch.Stop();
            GatherInfo(array);
        }
    }
}
