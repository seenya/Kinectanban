using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kinectanban.WebAPI.Models
{
    public class Wall
    {
        public string Id { get; set; }

        public IList<string> Lists { get; set; }

        public IList<Models.Card> Cards { get; set; }
    }
}
