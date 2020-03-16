using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortMathodsComparing
{
    public class SortInfo
    {
        public SortType SortType { get; set; }
        public DataType DataType { get; set; }
        public double Time { get; set; }
        public uint ElementsAmount { get; set; }
        public uint ComparisonAmount { get; set; }
        public uint SwapsAmount { get; set; }

        public override string ToString()
        {
            return "Sort Type: " + SortType.ToString() + "\n  Data Type: " + DataType.ToString() + 
                "\n  Time: " + Time + "\n  Elements Amount: " + ElementsAmount;
        }

    }

    public enum SortType
    {
        BUBBLE,
        SHELL,
        QUICK,
        INSERTION,
        SELECTION
    }

    public enum DataType
    {
        INT_ARRAY,
        STRING_ARRAY
    }
}
