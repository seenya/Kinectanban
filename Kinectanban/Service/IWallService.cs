using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kinectanban.Model;

namespace Kinectanban.Service
{
    public interface IWallService
    {
        IList<string> GetWallList();
        WallModel GetWall(string wallName);
        CardModel GetCard(string id);
    }
}
