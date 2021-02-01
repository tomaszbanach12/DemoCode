using System;
using Xunit;
using AutoFixture;

namespace DemoCode.Tests
{
    public class StringDemos
    {
        [Fact]
        public void Strings()
        {
            // Arrange
            var fixture = new Fixture();
            var sut = new NameJoiner();

            var firstName = fixture.Create("First_");
            var lastName = fixture.Create("Last_");

            // Act
            var result = sut.Join(firstName, lastName);

            // Assert
            Assert.True(result == $"{firstName} {lastName}");
        }
    }
}
