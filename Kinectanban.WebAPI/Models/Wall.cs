﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kinectanban.WebAPI.Models
{
    public class Wall
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public CardList[] Lists { get; set; }
    }
}
