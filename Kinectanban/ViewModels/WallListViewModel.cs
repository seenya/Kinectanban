using Kinectanban.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinectanban.ViewModels
{
    public class WallListViewModel : ViewModelBase
    {
        public IList<WallSummary> Walls { get; set; }
    }
}
