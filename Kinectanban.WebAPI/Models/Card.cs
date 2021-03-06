﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kinectanban.WebAPI.Models
{
    public class Card
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public string AssignedTo { get; set; }
        public string Type { get; set; }
        public bool IsReady { get; set; }
        public bool IsBlocked { get; set; }
        public string Estimate { get; set; }
        public KeyValuePair<string, string>[] ImportantAttributes { get; set; }
    }
}
