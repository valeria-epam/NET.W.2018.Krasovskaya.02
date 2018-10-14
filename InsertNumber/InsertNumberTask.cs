using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertNumber
{
    public class InsertNumberTask
    {
        /// <summary>
        /// Insert one numeber in the other number from index1 to index2 bits
        /// </summary>
        /// <param name="numSource"></param>
        /// <param name="numIn"></param>
        /// <param name="index1"></param>
        /// <param name="index2"></param>
        /// <returns></returns>
        public static int InsertNumber(int numSource, int numIn, int index1, int index2)
            {
                if (index2 < index1)
                {
                    throw new ArgumentException();
                }

                if (index1 < 0 & index1 > 31)
                {
                    throw new ArgumentOutOfRangeException(nameof(index1));
                }

                if (index2 < 0 & index2 > 31)
                {
                    throw new ArgumentOutOfRangeException(nameof(index2));
                }

                int count = index2 - index1;

                int mask1 = count < 31 ? int.MaxValue >> (31 - (count + 1)) : -1;
                int num = numIn & mask1;

                int mask2 = mask1 << index1;
                int mask3 = ~mask2;

                return (numSource & mask3) | (num << index1);
        }
        }
    }
