using System;
using Xunit;
using AutoFixture;
using System.Collections.Generic;

namespace DemoCode.Tests
{
    public class SequenceDemos
    {
        [Fact]
        public void SequenceOfStrings()
        {
            // Arrange
            var fixture = new Fixture();

            IEnumerable<string> messages = fixture.CreateMany<string>();

            // etc...
        }

        [Fact]
        public void ExplicitNumberOfItems()
        {
            // Arrange
            var fixture = new Fixture();

            IEnumerable<int> numbers = fixture.CreateMany<int>(3);

            // etc...
        }

        [Fact]
        public void AddingToExistingList()
        {
            // Arrange
            var fixture = new Fixture();

            var sut = new DebugMessageBuffer();

            fixture.AddManyTo<string>(sut.Messages, 10);

            // Act
            sut.WriteMessages();

            // Assert
            Assert.Equal(10, sut.MessagesWritten);
        }

        [Fact]
        public void AddToExistingListWithCreationFunction()
        {
            // Arrange
            var fixture = new Fixture();

            var sut = new DebugMessageBuffer();
            var rand = new Random();

            fixture.AddManyTo<string>(sut.Messages, () => rand.Next().ToString());
        }
    }
}
