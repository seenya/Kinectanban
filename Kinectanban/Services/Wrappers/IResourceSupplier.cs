using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinectanban.Services.Wrappers
{
    public interface IResourceSupplier
    {
        object FindResource(string key);
    }
}
