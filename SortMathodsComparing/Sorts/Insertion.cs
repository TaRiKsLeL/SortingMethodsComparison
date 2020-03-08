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

            for (int i = 1; i < array.Length; ++i)
            {
                int j = i - 1;
                while (j >= 0 && (array[i].CompareTo(array[j]) > 0))
                {
                    Foo.Swap<T>(ref array[j + 1], ref array[j]);
                    --j;
                }
            }

            stopwatch.Stop();
            GatherInfo(array);
        }
    }
}
