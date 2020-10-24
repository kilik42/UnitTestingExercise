using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,2,3,6)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,5,0)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var sub = new UnitTestMethods();
            //Act
            var actual2 = sub.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual2);
        }

        [Theory]
        [InlineData(2,3,6)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var test3 = new UnitTestMethods();
            //Act
            var actual3 = test3.Multiply(num1, num2)

            //Assert
            Assert.Equal(expected, actual3);
        }

        [Theory]
        [InlineData()]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange

            //Act

            //Assert

        }

        [Fact]
        public void YourMethodName()
        {
            //Arrange

            //Act

            //Assert

        }

        [Fact]
        public void YourMethodName2()
        {
            //Arrange

            //Act

            //Assert
        }
    }
}
