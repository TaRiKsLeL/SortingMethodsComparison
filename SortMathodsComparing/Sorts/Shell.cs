using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortMathodsComparing.Sorts
{
    class Shell : Sorter
    {
        public Shell() : base()
        {
            LastSortInfo.SortType = SortType.SHELL;
        }

        public override void Sort<T>(T[] array)
        {
            SetupTimer();
            var d = array.Length / 2;
            while (d >= 1){
                for (var i = d; i < array.Length; i++){
                    var j = i;
                    while ((j >= d) && (array[j - d].CompareTo(array[j])>0)){
                        Foo.Swap<T>(ref array[j], ref array[j - d]);
                        j -= d;
                    }
                }
                d /=  2;
            }
            stopwatch.Stop();
            GatherInfo(array);
        }
    }
}
