using Kinectanban.WebAPI.Services;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinectanban.WebAPI.Tests
{
    [TestFixture()]
    public class ConfigurationServiceTests
    {
        [Test()]
        public void GetValueForKey_ValueInAppSettings_ValueReturned()
        {
            ConfigurationService service = CreateConfigurationService();

            string value = service.GetValueForKey("valueinconfigfile");

            Assert.AreEqual("IExist!", value);
        }

        [Test()]
        public void GetValueForKey_ValueInAppSettingsAndEnvironmentVariable_AppSettingsValueReturned()
        {
            ConfigurationService service = CreateConfigurationService();

            string value = service.GetValueForKey("valueinconfigfileandenvironmentvariable");

            Assert.AreEqual("I'mHereAsWell", value);
        }

        [Test()]
        public void GetValueForKey_ValueInEnvironmentVariableOnly_ValueReturned()
        {
            ConfigurationService service = CreateConfigurationService();

            string value = service.GetValueForKey("valueinenvironmentvariableonly");

            Assert.AreEqual("I'mOnlyHere", value);
        }

        [Test()]
        public void GetValueForKey_ValueNotSet_NullIsReturned()
        {
            ConfigurationService service = CreateConfigurationService();

            string value = service.GetValueForKey("valuenotsetanywhere");

            Assert.IsNull(value);
        }

        private ConfigurationService CreateConfigurationService()
        {
            var mockEnvironmentVariableService = new Mock<IEnvironmentVariableService>();
            mockEnvironmentVariableService.Setup(x => x.GetValueForKey(It.Is<string>(s => s == "valueinconfigfileandenvironmentvariable"))).Returns("I'mHere");
            mockEnvironmentVariableService.Setup(x => x.GetValueForKey(It.Is<string>(s => s == "valueinenvironmentvariableonly"))).Returns("I'mOnlyHere");
            ConfigurationService service = new ConfigurationService(mockEnvironmentVariableService.Object);
            return service;
        }
    }
}
