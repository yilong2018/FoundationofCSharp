using M07L05CalculationLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace M07L05CalculationUnit.Tests
{
    public class CalculationsTests
    {
        [Fact]
        public void AddShoudReturnAddedDouble()
        {
            // Arrange
            Calculations cal = new Calculations();
            double expected = 33.33;

            // Action
            double actual = cal.Add(11.11, 22.22);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2,3,5)]
        [InlineData(3,3,6)]
        public void AddShouldReturnExpectedValue(double x, double y, double expected)
        {
            // Arrange
            Calculations cal = new Calculations();

            // Action
            double actual = cal.Add(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void SubShoudReturnSubedDouble()
        {
            // Arrange
            Calculations cal = new Calculations();
            double expected = -11.11;

            // Action
            double actual = cal.Subtract(11.11, 22.22);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MulShoudReturnMuledDouble()
        {
            // Arrange
            Calculations cal = new Calculations();
            double expected = 12;

            // Action
            double actual = cal.Multiply(3, 4);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DivShoudReturnDivedDouble()
        {
            // Arrange
            Calculations cal = new Calculations();
            double expected = 2;

            // Action
            double actual = cal.Divide(10, 5);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(15, 3, 5)]
        [InlineData(18, 3, 6)]
        [InlineData(18, 0, 0)]
        public void DivShouldReturnExpectedValue(double x, double y, double expected)
        {
            // Arrange
            Calculations cal = new Calculations();

            // Action
            double actual = cal.Divide(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
