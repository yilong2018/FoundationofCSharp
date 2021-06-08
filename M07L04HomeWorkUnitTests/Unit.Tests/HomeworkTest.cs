using M07L04HomeWorkUnit.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Unit.Tests
{
    public class HomeworkTest
    {
        [Fact]
        public void AddTenShouldReturnInt()
        {
            // Arrange
            Calculator cal = new Calculator();
            int expected = 20;

            // Act
            int actual = cal.AddTen(10);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,20)]
        [InlineData(11,21)]
        [InlineData(12,22)]
        [InlineData(13,23)]
        [InlineData(114,124)]
        [InlineData(101,111)]
        public void AddTenShouldReturnIntValue(int val, int expected)
        {
            // Arrange
            Calculator cal = new Calculator();

            // Act
            int actual = cal.AddTen(val);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
