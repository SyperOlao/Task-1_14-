using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1_14
{
    class MyMath
    {
        public static double MyLn(double x, int n, ref double LastElem)
        {
            double sum = x;
            LastElem = x;
            for (int i = 2; i <= n; i++)
            {
                sum += LastElem * -x * (i - 1) / i;
                LastElem = LastElem * -x * (i - 1) / i;
            }
            return sum;
        }

        public static double SumLast(double x, double E, ref int N)
        {
            double sum = 0;
            double pred = x;
            for (int i = 2; Math.Abs(pred) > E; i++)
            {
                sum += pred;
                N++;
                pred = pred * -x * (i - 1) / i;
            }
            return sum;
        }
    
    }
}
