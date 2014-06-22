using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Kinectanban.WebAPI.Services
{
    public class ConfigurationService : IConfigurationService
    {
        private IEnvironmentVariableService _environmentVariableService;
        public ConfigurationService(IEnvironmentVariableService environmentVariableService)
        {
            _environmentVariableService = environmentVariableService;
        }
        public string GetValueForKey(string key)
        {
            string value = ConfigurationManager.AppSettings[key];

            if (string.IsNullOrEmpty(value))
            {
                value = _environmentVariableService.GetValueForKey(key);
            }
            return value;
        }
    }
}