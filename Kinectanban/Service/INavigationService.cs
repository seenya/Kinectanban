using Kinectanban.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinectanban.Service
{
    public interface INavigationService
    {
        void GoBack();
        void Initialise();
        void SelectWall(WallViewModel wall);
        void SelectCard(CardViewModel card);
        void Refresh();
    }
}
