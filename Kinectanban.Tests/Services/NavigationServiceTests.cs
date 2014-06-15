using Kinectanban.Service;
using Kinectanban.ViewModel;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinectanban.Tests.Services
{
    [TestFixture()]
    public class NavigationServiceTests
    {
        [Test()]
        public void Initialise_NewObject_DataSetToWallListViewModel()
        {
            IMainWindowViewModel mainViewModel = new MainWindowViewModel();
            NavigationService service = CreateTestInstance(mainViewModel);

            service.Initialise();

            Assert.IsInstanceOf<WallListViewModel>(mainViewModel.SelectedData);
        }

        [Test()]
        public void GoBack_NewObject_ExitCommandExecuted()
        {

        }

        [Test()]
        public void GoBack_WallListViewModelSelected_ExitCommandExecuted()
        {

        }

        [Test()]
        public void GoBack_WallViewModelSelected_DataSetToWallListViewModel()
        {

        }

        [Test()]
        public void GoBack_CardViewModelSelected_DataSetToWallViewModel()
        {

        }

        [Test()]
        public void SelectWall_CardViewModelSelected_InvalidStateExceptionThrown()
        {

        }
    
        [Test()]
        public void SelectWall_WallViewModelSelected_InvalidStateExceptionThrown()
        {

        }

        [Test()]
        public void SelectWall_InitialiseNotCalled_InvalidStateExceptionThrown()
        {

        }

        [Test()]
        public void SelectWall_WallListViewModelSelected_DataSetToWallViewModel()
        {

        }

        [Test()]
        public void SelectCard_InitialiseNotCalled_InvalidStateExceptionThrown()
        {

        }

        [Test()]
        public void SelectCard_CardViewModelSelected_InvalidStateExceptionThrown()
        {

        }

        [Test()]
        public void SelectCard_WallViewModelSelected_DataSetToCardViewModel()
        {

        }

        [Test()]
        public void SelectCard_WallListViewModelSelected_InvalidStateExceptionThrown()
        {

        }

        [Test()]
        public void Refresh_InitialiseNotCalled_DataSetToWallListViewModel()
        {

        }

        [Test()]
        public void Refresh_WallListViewModelSelected_DataSetToWallListViewModel()
        {

        }

        [Test()]
        public void Refresh_WallViewModelSelected_DataSetToWallViewModel()
        {

        }

        [Test()]
        public void Refresh_CardViewModelSelected_DataSetToCardViewModel()
        {

        }

        private NavigationService CreateTestInstance(IMainWindowViewModel mainViewModel)
        {
            var mockWallService = new Mock<IWallService>();
            var wallList = new List<string>();
            wallList.Add("Wall1");
            mockWallService.Setup(x => x.GetWallList()).Returns(wallList);

            return new NavigationService(mainViewModel, mockWallService.Object);
        }
    }
}
