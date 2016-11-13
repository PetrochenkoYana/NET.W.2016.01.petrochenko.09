using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class MatrixFuncInterface
    {
        /// <summary>
        /// "Bubble" sorting of matrix strings with rule getting from first ICompare-type param
        /// If matrix strings is null it get last places
        /// </summary>
        /// <param name="rule">The type of object must implement ICompare interface</param>
        /// <param name="matrix"></param>
        public static void BubbleSort(int[][] matrix, IComparer<int[]> rule)
        {
            if (matrix == null || rule==null)
                throw new ArgumentNullException();
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length - i - 1; j++)
                {
                    if (matrix[j] == null || rule.Compare(matrix[j], matrix[j + 1]) == 1)
                        {
                            Swap(ref matrix[j], ref matrix[j + 1]);
                        }
                }
            }
        }

        /// <summary>
        /// "Bubble" sorting of matrix strings with rule getting from first ICompare-type param
        /// If matrix strings is null it get first places
        /// </summary>
        /// <param name="rule">The type of object must be delegate of comparing </param>
        /// <param name="matrix"></param>

        public static void BubbleSort(int[][] matrix, Comparison<int[]> rule)=> BubbleSort(matrix, new ComparisonAdapter(rule));
     
        private static void Swap(ref int[] a,ref int[] b)
        {
            var tmp = a;
            a = b;
            b = tmp;

        }
        /// <summary>
        /// Class adapter for comparison delegate to implement IComparer interface
        /// </summary>
        private class ComparisonAdapter : IComparer<int[]>
        {
            private readonly Comparison<int[]> comparer;

            public ComparisonAdapter(Comparison<int[]> rule )
            {
                comparer = rule;
            }
            public int Compare(int[] x, int[] y)
            {
                return comparer.Invoke(x,y);
            }
        }
    }
}
