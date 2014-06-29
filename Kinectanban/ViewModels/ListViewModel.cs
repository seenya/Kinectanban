using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Kinectanban.ViewModels
{
    public class ListViewModel
    {
        public string Name { get; set; }
        public ImageSource Icon { get; set; }
        public CardViewModel[] Cards { get; set; }
    }
}
