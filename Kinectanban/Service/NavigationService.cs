using Kinectanban.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinectanban.Service
{
    public class NavigationService :INavigationService 
    {
        private IMainWindowViewModel _mainWindowViewModel;
        private IWallService _wallService;

        public NavigationService(IMainWindowViewModel mainWindowViewModel, IWallService wallService)
        {
            _mainWindowViewModel = mainWindowViewModel;
            _wallService = wallService;
        }

        public void Initialise()
        {
            _mainWindowViewModel.SelectedData = GetNewWallListViewModel();
        }

        private ViewModelBase GetNewWallListViewModel()
        {
            return new WallListViewModel(){Walls = _wallService.GetWallList()};
        }

        public void GoBack()
        {
            Command.CommandList.ExitCommand.Execute(null);
        }

        public void SelectWall(ViewModel.WallViewModel wall)
        {
            throw new NotImplementedException();
        }

        public void SelectCard(ViewModel.CardViewModel card)
        {
            throw new NotImplementedException();
        }

        public void Refresh()
        {
            throw new NotImplementedException();
        }
    }
}
