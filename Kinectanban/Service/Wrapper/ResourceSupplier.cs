using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Kinectanban.Service.Wrapper
{
    public class ResourceSupplier : IResourceSupplier
    {
        private Application _application;
        public ResourceSupplier(Application application)
        {
            _application = application;
        }

        public object FindResource(string key)
        {
           return  _application.FindResource(key);
        }
    }
}
