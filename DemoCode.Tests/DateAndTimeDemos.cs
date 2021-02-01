using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using AutoFixture;

namespace DemoCode.Tests
{
    public class DateAndTimeDemos
    {
        [Fact]
        public void DateTimes()
        {
            // Arrange
            var fixture = new Fixture();
            DateTime logTime = fixture.Create<DateTime>();
            var message = fixture.Create<string>();

            // Act
            LogMessage logMessage = LogMessageCreator.Create(message, logTime);

            // Assert
            Assert.True(logMessage.Message == message);
            Assert.True(logMessage.Year == logTime.Year);
        }

        [Fact]
        public void TimeSpans()
        {
            // Arrange
            var fixture = new Fixture();

            var timeSpan = fixture.Create<TimeSpan>();

            // etc...
        }
    }
}
