﻿using System;
using Xunit;
using AutoFixture;

namespace DemoCode.Tests
{
    public class NumberDemos
    {
        [Fact]
        public void Ints()
        {
            // Arrange
            var sut = new IntCalculator();
            var fixture = new Fixture();

            // Act
            sut.Subtract(fixture.Create<int>());

            // Assert
            Assert.True(sut.Value < 0);
        }

        [Fact]
        public void Decimals()
        {
            // Arrange
            var sut = new DecimalCalculator();
            var fixture = new Fixture();

            // Act
            sut.Subtract(fixture.Create<decimal>());

            // Assert
            Assert.True(sut.Value < 0);
        }
    }
}
