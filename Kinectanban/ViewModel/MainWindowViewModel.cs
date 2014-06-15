using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinectanban.ViewModel
{
    public class MainWindowViewModel
    {

        public void Back()
        {
            Commands.CommandList.ExitCommand.Execute(null);
        }
    }
}
