using System;
using System.Numerics;

namespace Task1
{
    public class MyFrac : IMyNumber<MyFrac>, IComparable<MyFrac>
    {
        private BigInteger numerator;
        private BigInteger denominator;

        public MyFrac()
        {
            numerator = 0;
            denominator = 1;
        }

        public MyFrac(int numerator, int denominator)
        {
            this.numerator = new BigInteger(numerator);
            this.denominator = new BigInteger(denominator);

            CheckDenominator();
            CheckNumerator();
        }

        public MyFrac(long numerator, long denominator)
        {
            this.numerator = new BigInteger(numerator);
            this.denominator = new BigInteger(denominator);

            CheckDenominator();
            CheckNumerator();
        }

        public MyFrac(BigInteger numerator, BigInteger denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;

            CheckDenominator();
            CheckNumerator();
        }

        public BigInteger Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }

        public BigInteger Denominator
        {
            get { return denominator; }
            set { denominator = value; }
        }

        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }

        private void CheckNumerator()
        {
            if (numerator != 0)
            {
                BigInteger GCD =
                    GetGreatesCommonDivisor(BigInteger.Abs(numerator), BigInteger.Abs(denominator));

                numerator /= GCD;
                denominator /= GCD;
            }
        }

        private void CheckDenominator()
        {
            if (denominator < 0)
            {
                numerator *= (-1);
                denominator *= (-1);
            }
            else if (denominator == 0)
            {
                throw new Exception("Denominator cannot be zero");
            }
        }

        private static BigInteger GetGreatesCommonDivisor(BigInteger a, BigInteger b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                if (b > a)
                {
                    b -= a;
                }
            }

            return a;
        }

        public MyFrac Add(MyFrac fraction)
        {
            BigInteger numeratorNew = numerator * fraction.denominator + denominator * fraction.numerator;
            BigInteger denominatorNew = denominator * fraction.denominator;

            return new MyFrac(numeratorNew, denominatorNew);
        }

        public MyFrac Substract(MyFrac fraction)
        {
            BigInteger numeratorNew = numerator * fraction.denominator - denominator * fraction.numerator;
            BigInteger denominatorNew = denominator * fraction.denominator;

            return new MyFrac(numeratorNew, denominatorNew);
        }

        public MyFrac Multiply(MyFrac fraction)
        {
            BigInteger numeratorNew = numerator * fraction.numerator;
            BigInteger denominatorNew = denominator * fraction.denominator;

            return new MyFrac(numeratorNew, denominatorNew);
        }

        public MyFrac Divide(MyFrac fraction)
        {
            if (fraction.numerator == 0)
            {
                throw new DivideByZeroException("Division by zero");
            }

            BigInteger numeratorNew = numerator * fraction.denominator;
            BigInteger denominatorNew = denominator * fraction.numerator;

            return new MyFrac(numeratorNew, denominatorNew);
        }

        public int CompareTo(MyFrac fraction)
        {
            BigInteger numeratorNewFraction1 = numerator * fraction.denominator;
            BigInteger numeratorNewFraction2 = fraction.numerator * denominator;

            if (numeratorNewFraction1 > numeratorNewFraction2) return 1;
            else if (numeratorNewFraction1 < numeratorNewFraction2) return -1;
            else return 0;
        }
    }
}
