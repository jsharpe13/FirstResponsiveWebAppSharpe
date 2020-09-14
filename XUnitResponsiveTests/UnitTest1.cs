using System;
using Xunit;
using ResponsiveWebApp.Models;

namespace XUnitResponsiveTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestName()
        {
            //Arrange
            string expected = "John";

            //Act
            ResponsiveWebAppModel test = new ResponsiveWebAppModel();
            test.Name = expected;

            string actual = test.Name;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestBirthYear()
        {
            //Arrange
            int expected = 1990;

            //Act
            ResponsiveWebAppModel test = new ResponsiveWebAppModel();
            test.BirthYear = expected;

            int? actual = test.BirthYear;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestBirthMonth()
        {
            //Arrange
            int expected = 9;

            //Act
            ResponsiveWebAppModel test = new ResponsiveWebAppModel();
            test.BirthMonth = expected;

            int? actual = test.BirthMonth;

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void testBirthDay()
        {
            //Arrange
            int expected = 23;

            //Act
            ResponsiveWebAppModel test = new ResponsiveWebAppModel();
            test.BirthDay = expected;

            int? actual = test.BirthDay;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void testAgeOne()
        {
            //Arrange
            int tBirthYear = 2019;
            int tBirthMonth = 8;
            int tBirthDay = 13;
            int expected = 1;

            //Act
            ResponsiveWebAppModel test = new ResponsiveWebAppModel();
            test.BirthYear = tBirthYear;
            test.BirthMonth = tBirthMonth;
            test.BirthDay = tBirthDay;

            int? actual = test.AgeThisYear();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void testAgeZero()
        {
            //Arrange
            int tBirthYear = 2019;
            int tBirthMonth = 11;
            int tBirthDay = 13;
            int expected = 0;

            //Act
            ResponsiveWebAppModel test = new ResponsiveWebAppModel();
            test.BirthYear = tBirthYear;
            test.BirthMonth = tBirthMonth;
            test.BirthDay = tBirthDay;

            int? actual = test.AgeThisYear();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void testAll()
        {
            //Arrange
            string personName = "Mark";
            int tBirthYear = 2019;
            int tBirthMonth = 9;
            int tBirthDay = 13;
            string expected = "Name: Mark,Birth Year: 2019,Birth Month: 9,Birth Day: 13";

            //Act
            ResponsiveWebAppModel test = new ResponsiveWebAppModel();
            test.Name = personName;
            test.BirthYear = tBirthYear;
            test.BirthMonth = tBirthMonth;
            test.BirthDay = tBirthDay;

            string actual = test.ToString();

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
