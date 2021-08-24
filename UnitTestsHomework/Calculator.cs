using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestsHomework
{
    public class Calculator
    {
        public int GetSum(int firstTerm, int secondTerm)
        {
            return firstTerm + secondTerm;
        }

        public int GetSubtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        public int GetMultiplication(int multiplicand, int factor)
        {
            return multiplicand * factor;
        }

        public double GetDevide(int dividend, int divisor)
        {
            return dividend / divisor;
        }
    }
}
