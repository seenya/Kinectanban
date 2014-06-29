using Kinectanban.Exceptions;
using Kinectanban.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinectanban.Services
{
    public class NavigationService :INavigationService 
    {
        private IMainWindowViewModel _mainWindowViewModel;
        private IWallService _wallService;

        // State
        private WallViewModel _selectedWall;
        private CardViewModel _selectedCard;

        public NavigationService(IMainWindowViewModel mainWindowViewModel, IWallService wallService)
        {
            _mainWindowViewModel = mainWindowViewModel;
            _wallService = wallService;
        }

        public void Initialise()
        {
            _mainWindowViewModel.SelectedData = GetNewWallListViewModel();
        }

        private WallListViewModel GetNewWallListViewModel()
        {
            return _wallService.GetWallList();
        }

        public void GoBack()
        {
            if (_mainWindowViewModel.SelectedData == null || _mainWindowViewModel.SelectedData is WallListViewModel)
            {
                Command.CommandList.ExitCommand.Execute(null);
            }
            if(_mainWindowViewModel.SelectedData is WallViewModel)
            {
                _selectedWall = null;
                _mainWindowViewModel.SelectedData = new WallListViewModel();
            }
            else if(_mainWindowViewModel.SelectedData is CardViewModel)
            {
                _selectedCard = null;
                _mainWindowViewModel.SelectedData = _selectedWall;
            }
        }

        public void SelectWall(string wallId)
        {
            if (_selectedWall != null)
                throw new InvalidStateException("A wall is already selected");
            _selectedWall = _wallService.GetWall(wallId); 
            _mainWindowViewModel.SelectedData = _selectedWall;
        }

        public void SelectCard(ViewModels.CardViewModel card)
        {
            if (_selectedWall == null)
                throw new InvalidStateException("A wall has not yet been chosen");
            if (_selectedCard != null)
                throw new InvalidStateException("A card is already selected");
            _selectedCard = card;
            _mainWindowViewModel.SelectedData = _selectedCard;
        }

    }
}
