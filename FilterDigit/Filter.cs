using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterDigit
{
    public static class Filter
    {
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
                while (n != 0)
                {
                    if (Math.Abs(n%10)==digit)
                    {
                        return true;
                    }

                    n = n / 10;
                }

                return false;
            }
        }

        
    }
}
