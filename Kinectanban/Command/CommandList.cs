using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Kinectanban.Command
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

        private static ICommand _selectCardCommand;
        public static ICommand SelectCardCommand
        {
            get { return _selectCardCommand; }
            set { _selectCardCommand = value; }
        }

        private static ICommand _selectWallCommand;
        public static ICommand SelectWallCommand
        {
            get { return _selectWallCommand; }
            set { _selectWallCommand = value; }
        }
    }
}
