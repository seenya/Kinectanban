using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinectanban.Model
{
    public class WallModel
    {
        public string Name { get; set; }
        public IEnumerable<string> Lists { get; set; }
        public IEnumerable<CardModel> Cards { get; set; }
    }
}
