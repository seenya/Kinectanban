using Kinectanban.Models;
using Kinectanban.ViewModels;
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
        void SelectWall(WallSummary wall);
        void SelectCard(CardViewModel card);
    }
}
