using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNextBiggerNumber
{
    public static class FindNumber
    {
        /// <summary>
        /// Return the next bigger number, which consists of the digits of the original <paramref name="number"/>
        /// </summary>
        public static int FindNextBiggerNumber(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number));
            }

            char[] digits = number.ToString().ToCharArray();

            //Find the first digit that is smaller than the digit next to it
            int i;
            for (i = digits.Length - 1; i > 0; i--)
            {
                if (digits[i] > digits[i - 1])
                    break;
            }

            if (i == 0)
            {
                return -1;
            }

            // Find the smallest digit on right side of (i-1)'th digit that is greater than digits[i-1] 
            int x = digits[i - 1];
            int smallest = i;

            for (int j = i + 1; j < digits.Length; j++)
            {
                if (digits[j] > x && digits[j] < digits[smallest])
                {
                    smallest = j;
                }
            }

            Swap(ref digits[smallest], ref digits[i - 1]);

            Array.Sort(digits, i, digits.Length - i);

            return Int32.Parse(new string(digits));
        }

        /// <summary>
        /// Return the next bigger number, which consists of the digits of the original <paramref name="number"/> and the execution time 
        /// </summary>
        public static int FindNextBiggerNumberWithTime(int number, out TimeSpan time)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int result = FindNextBiggerNumber(number);
            stopWatch.Stop();
            time = stopWatch.Elapsed;
            return result;
        }

        /// <summary>
        /// Return the next bigger number, which consists of the digits of the original <paramref name="number"/> and the execution time
        /// </summary>
        public static (int result, TimeSpan time) FindNextBiggerNumberWithTime(int number)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int result = FindNextBiggerNumber(number);
            stopWatch.Stop();
            return (result, stopWatch.Elapsed);
        }

        private static void Swap(ref char a, ref char b)
        {
            char d = b;
            b = a;
            a = d;
        }


    }
}
