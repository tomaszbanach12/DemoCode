using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using AutoFixture;

namespace DemoCode.Tests
{
    public class CustomTypeDemos
    {
        [Fact]
        public void ManualCreation()
        {
            // Arrange
            var sut = new EmailMessageBuffer();

            var emailMessage = new EmailMessage("t@24.com", "Greetings", false);

            emailMessage.Subject = "Hello";

            // Act
            sut.AddMessage(emailMessage);

            // Assert
            Assert.Single(sut.Emails);
        }

        [Fact]
        public void AutoCreation()
        {
            // Arrange
            var fixture = new Fixture();
            var sut = new EmailMessageBuffer();

            var emailMessage = fixture.Create<EmailMessage>();

            // Act
            sut.AddMessage(emailMessage);

            // Assert
            Assert.Single(sut.Emails);
        }
    }
}
