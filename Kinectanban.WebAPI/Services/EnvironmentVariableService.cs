using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kinectanban.WebAPI.Services
{
    public class EnvironmentVariableService : IEnvironmentVariableService
    {
        public string GetValueForKey(string key)
        {
            return Environment.GetEnvironmentVariable(key);
        }
    }
}