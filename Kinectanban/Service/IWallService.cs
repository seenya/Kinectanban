using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kinectanban.Model;
using Kinectanban.ViewModel;

namespace Kinectanban.Service
{
    public interface IWallService
    {
        WallListViewModel GetWallList();
        WallViewModel GetWall(string wallName);
        CardViewModel GetCard(string id);
    }
}
