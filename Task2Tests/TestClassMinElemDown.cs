using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2;

namespace Task2Tests
{
    class TestClassMinElemDown:IComparer<int[]>
    {
        public int Compare(int[] a, int[] b)
        {
            if (b == null) return -1;
            if (ArrayMinElem(a) > ArrayMinElem(b)) return 1;
            if (ArrayMinElem(a) < ArrayMinElem(b)) return -1;
            else return 0;
        }

        private int ArrayMinElem(int[] a)
        {
            int min = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                    min = a[i];
            }
            return min;
        }
    }
}
