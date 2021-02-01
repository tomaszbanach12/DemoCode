using System;
using Xunit;
using AutoFixture;

namespace DemoCode.Tests
{
    public class GuidEnumDemos
    {
        [Fact]
        public void Guid()
        {
            // Arrange 
            var fixture = new Fixture();
            var sut = new EmailMessage(fixture.Create<string>(),
                                       fixture.Create<string>(),
                                       fixture.Create<bool>());

            sut.Id = fixture.Create<Guid>();

            // etc...
        }

        [Fact]
        public void Enum()
        {
            // Arrange 
            var fixture = new Fixture();
            var sut = new EmailMessage(fixture.Create<string>(),
                                       fixture.Create<string>(),
                                       fixture.Create<bool>());

            sut.MessageType = fixture.Create<EmailMessageType>();

            // etc...
        }
    }
}
