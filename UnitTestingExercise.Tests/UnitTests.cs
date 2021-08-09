using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1, 2, 3, 6)]
        [InlineData(2,2,2,6)]
        [InlineData(12,15,13,40)]
        [InlineData(10,5,2,17)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            var unitTest = new UnitTestMethods();
            //Arrange

            var actual = unitTest.Add(num1, num2, num3);
            //Act

            Assert.Equal(expected, actual);
            //Assert

        }

        [Theory]
        [InlineData(20,10,10)]
        [InlineData(53,20,33)]
        [InlineData(19,17,2)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            var unitTest = new UnitTestMethods();
            //Arrange

            var actual = unitTest.Subtract(minuend,subtrhend);
            //Act

            Assert.Equal(expected, actual);
            //Assert
        }

        [Theory]
        [InlineData(2,2,4)]
        [InlineData(4,2,8)]
        [InlineData(12,12,144)]
        [InlineData(7,6,42)]
        public void Multiply(int num1, int num2, int expected)
        {
            var unitTest = new UnitTestMethods();
            //Arrange

            var actual = unitTest.Multiply(num1,num2);
            //Act

            Assert.Equal(expected, actual);
            //Assert

        }

        [Theory]
        [InlineData(32,16,2)]
        [InlineData(12,3,4)]
        [InlineData(66,3,22)]
        public void Divide(int num1, int num2, int expected)
        {
            var unitTest = new UnitTestMethods();
            //Arrange

            var actual = unitTest.Divide(num1, num2);
            //Act

            Assert.Equal(expected, actual);
            //Assert

        }

        [Fact]
        public void MyAge()
        {
            var unitTest = new UnitTestMethods();

            var actual = unitTest.myAge();

            Assert.Equal(19, actual);


        }

        [Fact]
        public void myBirthYear()
        {
            var unitTest = new UnitTestMethods();

            var actual = unitTest.myBirthYear();

            Assert.Equal(2002, actual);
        }
    }
}
