﻿using Kinectanban.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinectanban.Services
{
    public interface INavigationService
    {
        void GoBack();
        void Initialise();
        void SelectWall(string wallId);
        void SelectCard(CardViewModel card);
    }
}
