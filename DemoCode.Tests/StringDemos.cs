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

            var firstName = fixture.Create<string>();
            var lastName = fixture.Create<string>();

            // Act
            var result = sut.Join(firstName, lastName);

            // Assert
            Assert.True(result == $"{firstName} {lastName}");
        }
    }
}
