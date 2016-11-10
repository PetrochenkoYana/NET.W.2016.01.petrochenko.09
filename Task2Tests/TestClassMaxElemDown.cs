using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2;

namespace Task2Tests
{
    class TestClassMaxElemDown:IComparer<int[]>
    {
        public int Compare(int[] a, int[] b)
        {
            if (b == null) return -1;
            if (ArrayMaxElem(a) < ArrayMaxElem(b)) return 1;
            if (ArrayMaxElem(a) > ArrayMaxElem(b)) return -1;
            else return 0;
        }

        private int ArrayMaxElem(int[] a)
        {
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                    max = a[i];
            }
            return max;
        }
    }
}
