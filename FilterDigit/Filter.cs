using System;
using System.Collections.Generic;

namespace FilterDigit
{
    public static class Filter
    {
        /// <summary>
        /// Filters <paramref name="numbers" /> by the specified <paramref name="digit" />
        /// </summary>
        /// <param name="numbers">The numbers to filter.</param>
        /// <param name="digit">The digit by which <paramref name="numbers" /> wil be filtered.</param>
        public static IEnumerable<int> ByDigit(IEnumerable<int> numbers, int digit)
        {
            foreach (var number in numbers)
            {
                if (ContainsDigit(number))
                {
                    yield return number;
                }
            }

            bool ContainsDigit(int n)
            {
                do
                {
                    if (Math.Abs(n % 10) == digit)
                    {
                        return true;
                    }

                    n = n / 10;
                }
                while (n != 0);

                return false;
            }
        }
    }
}