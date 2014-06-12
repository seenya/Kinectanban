using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinectanban.Model
{
    public class CardModel
    {

        public string Id { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public string AssignedTo { get; set; }
        public string AssignedList { get; set; }
        public string Type { get; set; }
        public bool IsReady { get; set; }
        public bool IsBlocked { get; set; }
        public CustomAttributeModel[] ImportantAttributes { get; set; }
    }
}
