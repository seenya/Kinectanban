using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinectanban.WebAPI.Services
{
    public interface IConfigurationService
    {
        string GetValueForKey(string key);
    }
}
