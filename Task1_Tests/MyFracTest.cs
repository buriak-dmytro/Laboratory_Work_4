using Task1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task1_Tests
{
    [TestClass]
    public class MyFracTest
    {
        [TestMethod]
        public void AddTest()
        {
            // arrange
            MyFrac frac1 = new MyFrac(9, 12);
            MyFrac frac2 = new MyFrac(5, 3);
            MyFrac frac3 = new MyFrac(29, 12);
            // act
            MyFrac sumOfFrac12 = frac1.Add(frac2);
            // assert
            Assert.AreEqual(frac3.ToString(), sumOfFrac12.ToString());
        }

        [TestMethod]
        public void SubstractTest()
        {
            // arrange
            MyFrac frac1 = new MyFrac(9, 12);
            MyFrac frac2 = new MyFrac(5, 3);
            MyFrac frac3 = new MyFrac(-11, 12);
            // act
            MyFrac DiffOfFrac12 = frac1.Substract(frac2);
            // assert
            Assert.AreEqual(frac3.ToString(), DiffOfFrac12.ToString());
        }

        [TestMethod]
        public void MultiplyTest()
        {
            // arrange
            MyFrac frac1 = new MyFrac(9, 12);
            MyFrac frac2 = new MyFrac(5, 3);
            MyFrac frac3 = new MyFrac(5, 4);
            // act
            MyFrac ProdOfFrac12 = frac1.Multiply(frac2);
            // assert
            Assert.AreEqual(frac3.ToString(), ProdOfFrac12.ToString());
        }

        [TestMethod]
        public void DivideTest()
        {
            // arrange
            MyFrac frac1 = new MyFrac(9, 12);
            MyFrac frac2 = new MyFrac(5, 3);
            MyFrac frac3 = new MyFrac(9, 20);
            // act
            MyFrac DivOfFrac12 = frac1.Divide(frac2);
            // assert
            Assert.AreEqual(frac3.ToString(), DivOfFrac12.ToString());
        }
    }
}
