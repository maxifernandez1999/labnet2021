using Entity;
using Entity.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace OperationTesting
{
    [TestClass]
    public class TestOperation
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestMethodDivideByZero()
        {
            //arrange
            Operation operation = new Operation(0);

            //act
            operation.DivideByZero();
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestMethodFormatException()
        {
            //arrange
            string text = "Texto de prueba";
            
            Operation operation = new Operation(15, float.Parse(text));
            
            //act
            operation.Divide();
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestMethodDivideException()
        {
            //arrange
            Operation operation = new Operation(3, 0);
            //act
            operation.Divide();
        }

        [TestMethod]
        
        public void TestMethodDivide()
        {
            //arrange
            Operation operation = new Operation(12, 3);
            //act
            float result = operation.Divide();

            //Assert
            Assert.IsTrue(result.GetType() == typeof(float));
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public void TestMethodThrowException()
        {
            //arrange
            Logic.ThrowException();
        }

        [TestMethod]
        [ExpectedException(typeof(CustomException))]
        public void TestMethodThrowCustomException()
        {
            //arrange
            Logic.ThrowCustomException();
        }


    }
}
