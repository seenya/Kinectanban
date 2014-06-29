using Kinectanban.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinectanban.ViewModels
{
    public class WallViewModel : ViewModelBase
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public ListViewModel[] Lists { get; set; }
    }
}
