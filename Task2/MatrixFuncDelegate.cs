using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class MatrixFuncDelegate
    {
        /// <summary>
        /// "Bubble" sorting of matrix strings with rule getting from first ICompare-type param
        /// If matrix strings is null it get last places
        /// </summary>
        /// <param name="rule">The type of object must implement ICompare interface</param>
        /// <param name="matrix"></param>
        public static void BubbleSort(int[][] matrix, IComparer<int[]> rule)=> BubbleSort(matrix, rule.Compare);

        /// <summary>
        /// "Bubble" sorting of matrix strings with rule getting from first delegate param
        /// If matrix strings is null it get last places
        /// </summary>
        /// <param name="rule">The type of object must be delegate of comparing </param>
        /// <param name="matrix"></param>

        public static void BubbleSort(int[][] matrix, Comparison<int[]> rule)
        {
            if (matrix == null || rule == null)
                throw new ArgumentNullException();
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length - i - 1; j++)
                {
                    if (matrix[j] == null || rule(matrix[j], matrix[j + 1]) == 1)
                    {
                        Swap(ref matrix[j], ref matrix[j + 1]);
                    }

                }
            }
        }

        private static void Swap(ref int[] a, ref int[] b)
        {
            var tmp = a;
            a = b;
            b = tmp;

        }
    }
}

