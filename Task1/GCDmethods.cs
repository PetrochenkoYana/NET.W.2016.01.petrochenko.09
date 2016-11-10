using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task1
{
    public delegate int GcdDelegate2(int a, int b);
    public delegate int GcdDelegate3(GcdDelegate2 gcdD2,int a, int b,int c);
    public delegate int GcdDelegateParams(GcdDelegate2 gcdD2, params int[] numbers);

    /// <summary>
    /// Class-Wrapper for containing static members(different methods for searching The Greatest Common Divisor(GCD))
    /// </summary>
    public static class GcdMethods
    {
        public static int Gcd(GcdDelegate2 method, int a, int b)
        {
            int gcd = method(a, b);
            return gcd;
        }
        public static int Gcd(GcdDelegate2 method, int a, int b,out long time)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Restart();
            int gcd = method(a, b);
            stopwatch.Stop();
            time = stopwatch.Elapsed.Ticks;
            return gcd;
        }
        public static int Gcd(GcdDelegate3 method,GcdDelegate2 gcdD2, int a, int b,int c)
        {
            int gcd = method(gcdD2,a, b, c);
            return gcd;
        }
        public static int Gcd(GcdDelegate3 method, GcdDelegate2 gcdD2, int a, int b,int c, out long time)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Restart();
            int gcd = method(gcdD2, a, b, c);
            stopwatch.Stop();
            time = stopwatch.Elapsed.Ticks;
            return gcd;
        }
        public static int Gcd(GcdDelegateParams method, GcdDelegate2 gcdD2,params int[]numbers)
        {
            int gcd = method(gcdD2,numbers);
            return gcd;
        }
        public static int Gcd(GcdDelegateParams method, GcdDelegate2 gcdD2, out long time,params int[] numbers)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Restart();
            int gcd = method(gcdD2, numbers);
            stopwatch.Stop();
            time = stopwatch.Elapsed.Ticks;
            return gcd;
        }
        /// <summary>
        /// Method for searching the greatest common divisor of two numbers with an algorithm created by Euclid
        /// </summary>
        /// <param name="a">First number </param>
        /// <param name="b">Second number</param>
        /// <returns>int variable for GCD</returns>
        public static int EuclidsGcd(int a, int b)
        {
            while (b != 0)
            {
                int tmp = b;
                b = a % b;
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
        public static int BinaryGcd(int a, int b)
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
                while ((b & 1) == 0)  /* Loop X */
                    b >>= 1;

                if (a > b)
                {
                    int t = b; b = a; a = t;
                }
                b = b - a;
            } while (b != 0);

            return a << shift;
        }

        /// <summary>
        /// Method for searching the greatest common divisor of three numbers with an algorithm created by Euclid
        /// </summary>
        /// <param name="gcdD2"></param>
        /// <param name="a">First number </param>
        /// <param name="b">Second number</param>
        /// <param name="c">Third number</param>
        /// <returns>int variable for GCD</returns>
        public static int Gcd3(GcdDelegate2 gcdD2,int a, int b, int c)
        {
            return gcdD2(gcdD2(a, b), c);
        }

        /// <summary>
        /// The method for searching GCD, but for more then 3 numbers
        /// </summary>
        /// <param name="gcdD2"></param>
        /// <param name="numbers">numbers searching GCD for</param>
        /// <returns>int variable for GCD</returns>
        public static int GcdParams(GcdDelegate2 gcdD2, params int[] numbers)
        {
            int i = 1;
            int res = gcdD2(Math.Abs(numbers[0]), Math.Abs(numbers[1]));
            while (i < numbers.Length - 1)
            {
                res = gcdD2(res, Math.Abs(numbers[i + 1]));
                i++;
            }
            return res;
        }
    }
}
