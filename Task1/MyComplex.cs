using System;

namespace Task1
{
    public class MyComplex : IMyNumber<MyComplex>
    {
        private double real;
        private double imaginary;

        public MyComplex()
        {
            real = 0;
            imaginary = 0;
        }

        public MyComplex(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public double Real
        {
            get { return real; }
            set { real = value; }
        }

        public double Imaginary
        {
            get { return imaginary; }
            set { imaginary = value; }
        }

        public override string ToString()
        {
            if (imaginary < 0)
            {
                return $"{real}{imaginary}*i";
            }

            return $"{real}+{imaginary}*i";
        }

        public MyComplex Add(MyComplex complexNumber)
        {
            double realNew = real + complexNumber.real;
            double imaginaryNew = imaginary + complexNumber.imaginary;

            return new MyComplex(realNew, imaginaryNew);
        }

        public MyComplex Substract(MyComplex complexNumber)
        {
            double realNew = real - complexNumber.real;
            double imaginaryNew = imaginary - complexNumber.imaginary;

            return new MyComplex(realNew, imaginaryNew);
        }

        public MyComplex Multiply(MyComplex complexNumber)
        {
            double realNew = real * complexNumber.real - imaginary * complexNumber.imaginary;
            double imaginaryNew = real * complexNumber.Imaginary + imaginary * complexNumber.real;

            return new MyComplex(realNew, imaginaryNew);
        }

        public MyComplex Divide(MyComplex complexNumber)
        {
            if (complexNumber.real == 0 & complexNumber.Imaginary == 0)
            {
                throw new DivideByZeroException("Division by zero");
            }

            double realNumeratorNew = real * complexNumber.real + imaginary * complexNumber.imaginary;
            double imaginaryNumeratorNew = imaginary * complexNumber.real - real * complexNumber.imaginary;
            double denominatorNew = 
                complexNumber.real * complexNumber.real + 
                complexNumber.imaginary * complexNumber.imaginary;

            double realNew = realNumeratorNew / denominatorNew;
            double imaginaryNew = imaginaryNumeratorNew / denominatorNew;

            return new MyComplex(realNew, imaginaryNew);
        }
    }
}
