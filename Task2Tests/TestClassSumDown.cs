using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2;

namespace Task2Tests
{
    class TestClassSumDown : IComparer<int[]> { 
        public int Compare(int[] a, int[] b)
        {
            if (b == null) return -1;
            if (ArraySum(a) < ArraySum(b)) return 1;
            if (ArraySum(a) > ArraySum(b)) return -1;
            else return 0;
        }

        /// <summary>
        /// Sum of array
        /// </summary>
        private static int ArraySum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
                sum += array[i];
            return sum;

        }
    }
}
