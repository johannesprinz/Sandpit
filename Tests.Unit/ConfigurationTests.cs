using FluentAssertions;
using NUnit.Framework;

namespace Tests.Unit
{
    [TestFixture]
    public class ConfigurationTests
    {
        [Test]
        public void Happy()
        {
            true.Should().BeTrue();
        }
    }
}
