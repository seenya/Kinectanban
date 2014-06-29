using Kinectanban.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Kinectanban.Services
{
    public interface IResourceService
    {
        Brush GetBrushForCard(CardModel card);
    }
}
