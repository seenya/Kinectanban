using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinectanban.Models
{
    public class CardModel
    {

        public string Id { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public string AssignedTo { get; set; }
        public bool IsDefect { get; set; }
        public bool IsReady { get; set; }
        public bool IsBlocked { get; set; }
        public string Estimate { get; set; }
        public IList<CustomAttributeModel> ImportantAttributes { get; set; }
    }
}
