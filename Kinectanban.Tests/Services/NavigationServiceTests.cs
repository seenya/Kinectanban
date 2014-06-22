using Kinectanban.Command;
using Kinectanban.Exceptions;
using Kinectanban.Model;
using Kinectanban.Service;
using Kinectanban.ViewModel;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Kinectanban.Tests.Services
{
    [TestFixture()]
    public class NavigationServiceTests
    {
        [SetUp()]
        public void BeforeEachTest()
        {
            CommandList.ExitCommand = null;
        }

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
            IMainWindowViewModel mainViewModel = new MainWindowViewModel();
            NavigationService service = CreateTestInstance(mainViewModel);
            var exitCommand = new Mock<ICommand>();
            exitCommand.Setup(x => x.Execute(null));
            CommandList.ExitCommand = exitCommand.Object;

            service.GoBack();

            exitCommand.VerifyAll();
        }

        [Test()]
        public void GoBack_WallListViewModelSelected_ExitCommandExecuted()
        {
            IMainWindowViewModel mainViewModel = new MainWindowViewModel();
            NavigationService service = CreateTestInstance(mainViewModel);
            service.Initialise();
            var exitCommand = new Mock<ICommand>();
            exitCommand.Setup(x => x.Execute(null));
            CommandList.ExitCommand = exitCommand.Object;

            service.GoBack();

            exitCommand.VerifyAll();
        }

        [Test()]
        public void GoBack_WallViewModelSelected_DataSetToWallListViewModel()
        {
            IMainWindowViewModel mainViewModel = new MainWindowViewModel();
            NavigationService service = CreateTestInstance(mainViewModel);
            service.Initialise();
            service.SelectWall("wall1");

            service.GoBack();

            Assert.IsInstanceOf<WallListViewModel>(mainViewModel.SelectedData);
        }

        [Test()]
        public void GoBack_CardViewModelSelected_DataSetToPreviousWallViewModel()
        {
            IMainWindowViewModel mainViewModel = new MainWindowViewModel();
            NavigationService service = CreateTestInstance(mainViewModel);
            service.Initialise();
            service.SelectWall("wall1");
            var originalData = mainViewModel.SelectedData;
            service.SelectCard(new CardViewModel());

            service.GoBack();

            Assert.IsInstanceOf<WallViewModel>(mainViewModel.SelectedData);
            Assert.AreSame(originalData, mainViewModel.SelectedData);
        }

        [Test(), ExpectedException(typeof(InvalidStateException))]
        public void SelectWall_CardViewModelSelected_InvalidStateExceptionThrown()
        {
            IMainWindowViewModel mainViewModel = new MainWindowViewModel();
            NavigationService service = CreateTestInstance(mainViewModel);
            service.Initialise();
            service.SelectWall("wall1");
            service.SelectCard(new CardViewModel());

            service.SelectWall("wall1");
        }
    
        [Test(), ExpectedException(typeof(InvalidStateException))]
        public void SelectWall_WallViewModelSelected_InvalidStateExceptionThrown()
        {
            IMainWindowViewModel mainViewModel = new MainWindowViewModel();
            mainViewModel.SelectedData = new WallViewModel();
            NavigationService service = CreateTestInstance(mainViewModel);
            service.Initialise();
            service.SelectWall("wall1");

            service.SelectWall("wall2");
        }

        [Test()]
        public void SelectWall_WallListViewModelSelected_DataSetToWallViewModel()
        {
            IMainWindowViewModel mainViewModel = new MainWindowViewModel();
            mainViewModel.SelectedData = new WallViewModel();
            NavigationService service = CreateTestInstance(mainViewModel);
            service.Initialise();

            service.SelectWall("wall1");

            Assert.IsInstanceOf<WallViewModel>(mainViewModel.SelectedData);
        }

        [Test(), ExpectedException(typeof(InvalidStateException))]
        public void SelectCard_InitialiseNotCalled_InvalidStateExceptionThrown()
        {
            IMainWindowViewModel mainViewModel = new MainWindowViewModel();
            mainViewModel.SelectedData = new WallViewModel();
            NavigationService service = CreateTestInstance(mainViewModel);

            service.SelectCard(new CardViewModel());
        }

        [Test(), ExpectedException(typeof(InvalidStateException))]
        public void SelectCard_CardViewModelSelected_InvalidStateExceptionThrown()
        {
            IMainWindowViewModel mainViewModel = new MainWindowViewModel();
            mainViewModel.SelectedData = new WallViewModel();
            NavigationService service = CreateTestInstance(mainViewModel);
            service.Initialise();
            service.SelectWall("wall1");
            service.SelectCard(new CardViewModel());

            service.SelectCard(new CardViewModel());
        }

        [Test()]
        public void SelectCard_WallViewModelSelected_DataSetToCardViewModel()
        {
            IMainWindowViewModel mainViewModel = new MainWindowViewModel();
            mainViewModel.SelectedData = new WallViewModel();
            NavigationService service = CreateTestInstance(mainViewModel);
            service.Initialise();
            service.SelectWall("wall1");

            service.SelectCard(new CardViewModel());

            Assert.IsInstanceOf<CardViewModel>(mainViewModel.SelectedData);
        }

        [Test(), ExpectedException(typeof(InvalidStateException))]
        public void SelectCard_WallListViewModelSelected_InvalidStateExceptionThrown()
        {
            IMainWindowViewModel mainViewModel = new MainWindowViewModel();
            mainViewModel.SelectedData = new WallViewModel();
            NavigationService service = CreateTestInstance(mainViewModel);
            service.Initialise();

            service.SelectCard(new CardViewModel());
        }

        private NavigationService CreateTestInstance(IMainWindowViewModel mainViewModel)
        {
            var mockWallService = new Mock<IWallService>();
            var wallList = new List<WallSummary>();
            wallList.Add(new WallSummary() { ID="w1", Name="Wall1" });
            var wallViewModel = new WallListViewModel() { Walls = wallList };
            mockWallService.Setup(x => x.GetWallList()).Returns(wallViewModel);
            mockWallService.Setup(x => x.GetWall(It.IsAny<string>())).Returns(new WallViewModel());

            return new NavigationService(mainViewModel, mockWallService.Object);
        }
    }
}
