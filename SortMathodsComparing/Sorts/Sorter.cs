using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace SortMathodsComparing
{
    public abstract class Sorter
    {
        protected const int timerRate = 10;
        protected Stopwatch stopwatch;

        public SortInfo LastSortInfo { get; set; }

        public Sorter()
        {
            LastSortInfo = new SortInfo();
        }

        public abstract void Sort<T>(T[] array) where T : IComparable;

        protected void GatherInfo<T>(T[] array)
        {
            LastSortInfo.ElementsAmount = (uint)array.Length;
            LastSortInfo.Time = stopwatch.Elapsed.TotalMilliseconds;

            if (typeof(T) == typeof(int)) { LastSortInfo.DataType = DataType.INT_ARRAY; }
            else if (typeof(T) == typeof(string)) { LastSortInfo.DataType = DataType.STRING_ARRAY; }
        }

        protected void SetupTimer()
        {
            LastSortInfo.ComparisonAmount = 0;
            LastSortInfo.ElementsAmount = 0;
            LastSortInfo.SwapsAmount = 0;
            LastSortInfo.Time = 0;

            stopwatch = new Stopwatch();

            stopwatch.Start();
        }
    }
}

public static class Foo
{
    public static void Swap<T>(ref T lhs, ref T rhs)
    {
        T temp = lhs;
        lhs = rhs;
        rhs = temp;
    }
}