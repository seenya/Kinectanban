using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kinectanban.Models;
using Kinectanban.ViewModels;

namespace Kinectanban.Services
{
    public interface IWallService
    {
        WallListViewModel GetWallList();
        WallViewModel GetWall(string wallName);
        CardViewModel GetCard(string id);
    }
}
