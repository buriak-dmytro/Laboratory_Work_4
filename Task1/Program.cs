using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void TestAPlusBSquare<T>(T a, T b) where T : IMyNumber<T>
        {
            Console.WriteLine("=== Starting testing (a+b)^2=a^2+2ab+b^2 with a = " + a + ", b = " + b + " ===");
            T aPlusB = a.Add(b);
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("(a+b) = " + aPlusB);
            Console.WriteLine("(a+b)^2 = " + aPlusB.Multiply(aPlusB));
            Console.WriteLine(" = = = ");
            T curr = a.Multiply(a);
            Console.WriteLine("a^2 = " + curr);
            T wholeRightPart = curr;
            curr = a.Multiply(b);
            curr = curr.Add(curr);
            Console.WriteLine("2*a*b = " + curr);
            wholeRightPart = wholeRightPart.Add(curr);
            curr = b.Multiply(b);
            Console.WriteLine("b^2 = " + curr);
            wholeRightPart = wholeRightPart.Add(curr);
            Console.WriteLine("a^2+2ab+b^2 = " + wholeRightPart);
            Console.WriteLine("=== Finishing testing (a+b)^2=a^2+2ab+b^2 with a = " + a + ", b = " + b + " ===");
        }

        static void TestSquaresDifference<T>(T a, T b) where T : IMyNumber<T>
        {
            Console.WriteLine("=== Starting testing (a-b)=(a^2-b^2)/(a+b) with a = " + a + ", b = " + b + " ===");
            T aMinusB = a.Substract(b);
            Console.WriteLine("(a-b) = " + aMinusB);
            Console.WriteLine(" = = = ");
            T aSquared = a.Multiply(a);
            Console.WriteLine("a^2 = " + aSquared);
            T bSquared = b.Multiply(b);
            Console.WriteLine("b^2 = " + bSquared);
            T numeratorRight = aSquared.Substract(bSquared);
            Console.WriteLine("a^2-b^2 = " + numeratorRight);
            T denominatorRight = a.Add(b);
            Console.WriteLine("a+b = " + denominatorRight);
            T fractionRight = numeratorRight.Divide(denominatorRight);
            Console.WriteLine("(a^2-b^2)/(a+b) = " + fractionRight);
            Console.WriteLine("=== Finishing testing (a-b)=(a^2-b^2)/(a+b) with a = " + a + ", b = " + b + " ===");
        }

        static void TestIComparableOfMyFracImplementation()
        {
            Console.WriteLine("=== Starting testing IComparable<MyFrac> implementation ===");
            Random randomGenerator = new Random();
            List<MyFrac> list = new List<MyFrac>(10);
            Console.WriteLine("Unsorted:");
            for (int i = 0; i < 10; i++)
            {
                list.Add(new MyFrac(randomGenerator.Next(-10000, 10000), randomGenerator.Next(-10000, 10000)));
                Console.Write($"{list[i]} ");
            }
            Console.WriteLine();
            list.Sort();
            Console.WriteLine("Sorted:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{list[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine("=== Finishing testing IComparable<MyFrac> implementation ===");
        }

        static void Main()
        {
            TestAPlusBSquare(new MyFrac(1, 3), new MyFrac(1, 6));
            TestAPlusBSquare(new MyComplex(1, 3), new MyComplex(1, 6));

            TestSquaresDifference(new MyFrac(1, 6), new MyFrac(1, 3));
            TestSquaresDifference(new MyComplex(1, 6), new MyComplex(1, 3));

            TestIComparableOfMyFracImplementation();

            Console.ReadLine();
        }
    }
}
