using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortMathodsComparing.Sorts
{
    public class Quick : Sorter
    {
        public Quick() : base()
        {
            LastSortInfo.SortType = SortType.QUICK;
        }

        public override void Sort<T>(T[] array)
        {
            SetupTimer();
            QuickSort(array, 0, array.Length - 1);
            stopwatch.Stop();
            GatherInfo(array);
        }

        private void QuickSort<T>(T[] array, int left, int right) where T : IComparable
        {
            int i, j;
            i = left; j = right;
            IComparable pivot = array[left];

            while (i <= j)
            {
                for (; (array[i].CompareTo(pivot) < 0) && (i.CompareTo(right) < 0); i++) ;
                for (; (pivot.CompareTo(array[j]) < 0) && (j.CompareTo(left) > 0); j--) ;

                if (i <= j)
                    Foo.Swap(ref array[i++], ref array[j--]);

            }
            if (left < j) QuickSort(array, left, j);
            if (i < right) QuickSort(array, i, right);
        }
    }
}
