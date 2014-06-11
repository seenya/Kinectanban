using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinectanban.Model
{
    public class CardModel
    {
        public CardModel()
        {
        }

        public string Id { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public string AssignedTo { get; set; }
        public CustomAttributeModel[] ImportantAttributes { get; set; }
    }
}
