using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTestsHomework.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void GetSum_5_Plus_5_Eq_10()
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            var result = calculator.GetSum(5, 5);

            //Assert
            Assert.Equal(10, result);
        }

        [Fact]
        public void GetSubtract_5_Minus_5_Eq_0()
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            var result = calculator.GetSubtract(5, 5);

            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void GetMultiplication_5_Multiply_5_Eq_25()
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            var result = calculator.GetMultiplication(5, 5);

            //Assert
            Assert.Equal(25, result);
        }

        [Fact]
        public void GetDevide_5_Divide_5_Eq_1()
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            var result = calculator.GetDevide(5, 5);

            //Assert
            Assert.Equal(1, result);
        }
    }
}
