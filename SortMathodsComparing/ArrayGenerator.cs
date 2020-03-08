using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortMathodsComparing
{
    public static class ArrayGenerator
    {
        static Random rand;

        public static string[] GenerateStringArray(int amount, int digits)
        {
            rand = new Random();
            string[] array = new string[amount];

            for (int i = 0; i < amount; i++)
            {
                string str="";
                for(int j = 0; j < digits; j++)
                {
                    str += (char)rand.Next('a', 'z');
                }
                array[i] = str;
            }
            return array;
        }

        public static int[] GenerateIntArray(int amount, int digits)
        {
            rand = new Random();
            int[] array = new int[amount];

            for (int i = 0; i < amount; i++)
            {
                array[i] = rand.Next(0, GetMaxValueByDigits(digits));
            }

            return array;
        }

        private static int GetMaxValueByDigits(int digits)
        {
            string num = "";
            for(int i = 0; i < digits; i++)
            {
                num += "9";
            }

            return Convert.ToInt32(num);
        }
    }

}
