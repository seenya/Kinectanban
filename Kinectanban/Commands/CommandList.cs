using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Kinectanban.Commands
{
    public class CommandList
    {

        private static ICommand _exitCommand;

        public static ICommand ExitCommand
        {
            get { return _exitCommand; }
            set { _exitCommand = value; }
        }

        private static ICommand _backCommand;
        public static ICommand BackCommand
        {
            get { return _backCommand; }
            set { _backCommand = value; }
        }

    }
}
