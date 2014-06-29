using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kinectanban.WebAPI.Models
{
    public class CardList
    {
        public string Name { get; set; }
        public Card[] Cards { get; set; }
    }
}