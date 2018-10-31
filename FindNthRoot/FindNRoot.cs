﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNthRoot
{
    public static class FindNRoot
    {
        public static double FindRoot(double number, int rootPower, double epsilon)
        {
            if (rootPower < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(rootPower));
            }

            if (epsilon <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(epsilon));
            }

            if (number < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number));
            }

            double x0 = number / rootPower;
            double x1 = (1.0 / rootPower) * (((rootPower - 1) * x0) + (number / Power(x0, rootPower - 1)));
            while (Math.Abs(x1 - x0) > epsilon)
            {
                x0 = x1;
                x1 = (1.0 / rootPower) * (((rootPower - 1) * x0) + (number / Power(x0, rootPower - 1)));
            }

            return x1;
        }

        private static double Power(double number, int power)
        {
            double result = number;
            for (int i = 1; i < power; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}
