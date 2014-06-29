using Kinectanban.Services;
using Kinectanban.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Kinectanban.Command
{
    public class SelectWallCommand : ICommand
    {
        private readonly INavigationService _navigationService;

        public SelectWallCommand(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter)
        {
            string wallId = (string)parameter;
            _navigationService.SelectWall(wallId);
        }        
    }
}
