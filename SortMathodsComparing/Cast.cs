using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortMathodsComparing
{
    public static class Cast<T>
    {
        public static T Object(object obj)
        {
            T temp = (T)obj;
            return temp;
        }

        public static T[] ObjectsArray(object[] obj)
        {
            T[] tempArr = new T[obj.Length];
            for(int i = 0; i < obj.Length;i++)
            {
                tempArr[i] = (T)obj[i];
            }
            return tempArr;
        }


    }
}
