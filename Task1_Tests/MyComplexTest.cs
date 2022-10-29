using Task1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task1_Tests
{
    [TestClass]
    public class MyComplexTest
    {
        [TestMethod]
        public void AddTest()
        {
            // arrange
            MyComplex complex1 = new MyComplex(9, 12);
            MyComplex complex2 = new MyComplex(5, 3);
            MyComplex complex3 = new MyComplex(14, 15);
            // act
            MyComplex sumOfCompl12 = complex1.Add(complex2);
            // assert
            Assert.AreEqual(complex3.ToString(), sumOfCompl12.ToString());
        }

        [TestMethod]
        public void SubstractTest()
        {
            // arrange
            MyComplex complex1 = new MyComplex(9, 12);
            MyComplex complex2 = new MyComplex(5, 3);
            MyComplex complex3 = new MyComplex(4, 9);
            // act
            MyComplex DiffOfCompl12 = complex1.Substract(complex2);
            // assert
            Assert.AreEqual(complex3.ToString(), DiffOfCompl12.ToString());
        }

        [TestMethod]
        public void MultiplyTest()
        {
            // arrange
            MyComplex complex1 = new MyComplex(9, 12);
            MyComplex complex2 = new MyComplex(5, 3);
            MyComplex complex3 = new MyComplex(9, 87);
            // act
            MyComplex ProdOfCompl12 = complex1.Multiply(complex2);
            // assert
            Assert.AreEqual(complex3.ToString(), ProdOfCompl12.ToString());
        }

        [TestMethod]
        public void DivideTest()
        {
            // arrange
            MyComplex complex1 = new MyComplex(9, 12);
            MyComplex complex2 = new MyComplex(5, 3);
            MyComplex complex3 = new MyComplex(2.3823529411764706, -0.9705882352941176);
            // act
            MyComplex DivOfCompl12 = complex1.Divide(complex2);
            // assert
            Assert.AreEqual(complex3.ToString(), DivOfCompl12.ToString());
        }
    }
}
