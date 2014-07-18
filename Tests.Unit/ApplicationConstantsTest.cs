using FluentAssertions;
using JohannesPrinz.Sandpit.Application;
using NUnit.Framework;

namespace JohannesPrinz.Sandpit.Tests.Unit
{
    [TestFixture]
    public class ConstantsTests
    {
        [Test]
        public void Application_constants_are_as_expected()
        {
            Constants.Assembly.Company.Should().Be("Johannes.Prinz");
            Constants.Assembly.Copyright.Should().Be("Copyright ©  2014");
            Constants.Assembly.Trademark.Should().Be("Johannes Prinz");
            Constants.Assembly.Culture.Should().Be("en-US");
            Constants.Assembly.ComVisible.Should().Be(false);
            Constants.Assembly.AssemblyVersion.Should().Be("1.0.0.0");
            Constants.Assembly.AssemblyFileVersion.Should().Be("1.0.0.0");
        }
    }
}
