using Kinectanban.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Kinectanban.Service
{
    public interface IResourceService
    {
        Brush GetBrushForCard(CardModel card);
    }
}
