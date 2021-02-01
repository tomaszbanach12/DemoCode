using System;
using Xunit;
using AutoFixture;
using System.Net.Mail;

namespace DemoCode.Tests
{
    public class EmailAddressDemos
    {
        [Fact]
        public void Email()
        {
            // Arrange
            var fixture = new Fixture();

            var localPart = fixture.Create<EmailAddressLocalPart>().LocalPart;
            var domain = fixture.Create<DomainName>().Domain;
            var fullAddress = $"{localPart}@{domain}";

            var sut = new EmailMessage(fullAddress,
                                       fixture.Create<string>(),
                                       fixture.Create<bool>());

            // etc...
        }

        [Fact]
        public void EmailFromSystemDotNet()
        {
            // Arrange
            var fixture = new Fixture();

            var sut = new EmailMessage(fixture.Create<MailAddress>().Address,
                                       fixture.Create<string>(),
                                       fixture.Create<bool>());

            // etc...
        }
    }
}
