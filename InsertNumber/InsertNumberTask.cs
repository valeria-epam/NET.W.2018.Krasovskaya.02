using System;

namespace InsertNumber
{
    public class InsertNumberTask
    {
        /// <summary>
        /// Insert one number in the other number from <paramref name="index1" /> to <paramref name="index2" /> bits
        /// </summary>
        /// <param name="numSource">The number source.</param>
        /// <param name="numIn">The number which wil be inserted.</param>
        /// <param name="index1">The start position to insert.</param>
        /// <param name="index2">The end position to insert.</param>
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
