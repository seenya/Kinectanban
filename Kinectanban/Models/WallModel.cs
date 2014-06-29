using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinectanban.Models
{
    public class WallModel
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public ListModel[] Lists { get; set; }
    }
}
