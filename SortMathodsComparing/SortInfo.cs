using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortMathodsComparing
{
    class SortInfo
    {
        public SortType SortType { get; set; }
        public DataType DataType { get; set; }
        public int ElementsAmount { get; set; }
        public int ComparisonAmount { get; set; }
        public int SwapsAmount { get; set; }

    }

    public enum SortType
    {
        BUBBLE,
        SHELL,
        QUICK
    }

    public enum DataType
    {
        INT_ARRAY,
        STRING_ARRAY
    }
}
