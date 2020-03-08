using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortMathodsComparing.Sorts
{
    public class Bubble : Sorter
    {
        public Bubble() : base()
        {
            LastSortInfo.SortType = SortType.BUBBLE;
        }

        public override void Sort<T>(T[] array)
        {
            SetupTimer();

            for (int j = 0; j <= array.Length - 2; j++)
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    LastSortInfo.ComparisonAmount++;
                    if (array[i].CompareTo(array[i + 1]) > 0)
                    {
                        LastSortInfo.SwapsAmount++;
                        Foo.Swap<T>(ref array[i], ref array[i + 1]);
                    }
                }
            }
            stopwatch.Stop();
            GatherInfo(array);
        }
    }
}
