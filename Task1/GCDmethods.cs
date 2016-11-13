using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task1
{
    /// <summary>
    /// Class-Wrapper for containing static members(different methods for searching The Greatest Common Divisor(GCD))
    /// </summary>
    public static class GcdMethods
    {
        public static int GcdEuclid(int a, int b) => GcdFunc(EuclidsAlgoritm,a,b);
        public static int GcdEuclid(int a, int b, out long time) => GcdFunc(EuclidsAlgoritm, a, b, out time);
        public static int GcdEuclid(int a, int b, int c) => GcdFunc(EuclidsAlgoritm, a, b, c);
        public static int GcdEuclid(int a, int b, int c, out long time) => GcdFunc(EuclidsAlgoritm, a, b, c, out time);
        public static int GcdEuclid(params int[] numbers) => GcdFunc(EuclidsAlgoritm, numbers);
        public static int GcdEuclid(out long time, params int[] numbers) => GcdFunc(EuclidsAlgoritm, out time, numbers);
        public static int GcdBinary(int a, int b) => GcdFunc(BinaryAlgoritm, a, b);
        public static int GcdBinary(int a, int b, out long time) => GcdFunc(BinaryAlgoritm, a, b, out time);
        public static int GcdBinary(int a, int b, int c) => GcdFunc(BinaryAlgoritm, a, b, c);
        public static int GcdBinary(int a, int b, int c, out long time) => GcdFunc(BinaryAlgoritm, a, b, c, out time);
        public static int GcdBinary(params int[] numbers) => GcdFunc(BinaryAlgoritm, numbers);
        public static int GcdBinary(out long time, params int[] numbers) => GcdFunc(BinaryAlgoritm, out time, numbers);

        /// <summary>
        /// Method for searching the greatest common divisor of two numbers with an algorithm created by Euclid
        /// </summary>
        /// <param name="a">First number </param>
        /// <param name="b">Second number</param>
        /// <returns>int variable for GCD</returns>
        private static int EuclidsAlgoritm(int a, int b)
        {
            while (b != 0)
            {
                int tmp = b;
                b = a%b;
                a = tmp;
            }
            return Math.Abs(a);
        }

        /// <summary>
        ///  Method for searching the greatest common divisor of two numbers with an binary algorithm created by Josef Stein
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>int variable for GCD</returns>
        private static int BinaryAlgoritm(int a, int b)
        {
            int shift;
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a == 0) return b;
            if (b == 0) return a;

            for (shift = 0; ((a | b) & 1) == 0; ++shift)
            {
                a >>= 1;
                b >>= 1;
            }

            while ((a & 1) == 0)
                a >>= 1;
            do
            {
                while ((b & 1) == 0) /* Loop X */
                    b >>= 1;

                if (a > b)
                {
                    int t = b;
                    b = a;
                    a = t;
                }
                b = b - a;
            } while (b != 0);

            return a << shift;
        }

        /// <summary>
        /// The method for searching GCD of 2 numbers
        /// </summary>
        /// <param name="gcdAlgoritm">Algoritm of GCD</param>
        private static int GcdFunc(Func<int, int, int> gcdAlgoritm, int a, int b)
        {
            return gcdAlgoritm(a,b);
        }

        /// <summary>
        /// The method for searching GCD of 2 numbers
        /// </summary>
        /// <param name="gcdAlgoritm">Algoritm of GCD</param>
        /// <param name="time">Duration of method</param>
        private static int GcdFunc(Func<int, int, int> gcdAlgoritm, int a, int b, out long time)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Restart();
            int gcd = GcdFunc(gcdAlgoritm,a,b);
            stopwatch.Stop();
            time = stopwatch.Elapsed.Ticks;
            return gcd;
        }

        /// <summary>
        /// The method for searching GCD of 3 numbers
        /// </summary>
        /// <param name="gcdAlgoritm">Algoritm of GCD</param>
        private static int GcdFunc(Func<int, int, int> gcdAlgoritm, int a, int b, int c)
        {
            return gcdAlgoritm(gcdAlgoritm(a, b), c);
        }

        /// <summary>
        /// The method for searching GCD of 3 numbers
        /// </summary>
        /// <param name="gcdAlgoritm">Algoritm of GCD</param>
        /// <param name="time">Duration of method</param>
        private static int GcdFunc(Func<int, int, int> gcdAlgoritm, int a, int b, int c, out long time)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Restart();
            int gcd = GcdFunc(gcdAlgoritm,a,b,c);
            stopwatch.Stop();
            time = stopwatch.Elapsed.Ticks;
            return gcd;
        }

        /// <summary>
        /// The method for searching GCD for more then 3 numbers
        /// </summary>
        /// <param name="gcdAlgoritm">Algoritm of GCD</param>
        /// <param name="numbers">numbers searching GCD for</param>
        /// <returns>int variable for GCD</returns>
        private static int GcdFunc(Func<int, int, int> gcdAlgoritm, params int[] numbers)
        {
            int i = 1;
            int res = gcdAlgoritm(Math.Abs(numbers[0]), Math.Abs(numbers[1]));
            while (i < numbers.Length - 1)
            {
                res = gcdAlgoritm(res, Math.Abs(numbers[i + 1]));
                i++;
            }
            return res;
        }
        /// <summary>
        /// The method for searching GCD for more then 3 numbers
        /// </summary>
        /// <param name="gcdAlgoritm">Algoritm of GCD</param>
        /// <param name="time">Duration of method</param>
        /// <param name="numbers">numbers searching GCD for</param>
        /// <returns>int variable for GCD</returns>
        private static int GcdFunc(Func<int, int, int> gcdAlgoritm, out long time, params int[] numbers)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Restart();
            int gcd = GcdFunc(gcdAlgoritm, numbers);
            stopwatch.Stop();
            time = stopwatch.Elapsed.Ticks;
            return gcd;
        }
    }
}


