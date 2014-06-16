using Kinectanban.Command;
using Kinectanban.Service;
using Kinectanban.ViewModel;
using Microsoft.Practices.Unity;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Kinectanban
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        void App_Startup(object sender, StartupEventArgs e)
		{

            using (IUnityContainer container = new UnityContainer())
            {

                container.RegisterTypes(
                   AllClasses.FromAssembliesInBasePath(),
                   WithMappings.FromMatchingInterface,
                   WithName.Default,
                   WithLifetime.ContainerControlled);

                string wallServiceBaseUri = ConfigurationManager.AppSettings["WallServiceBaseUri"];
                IRestClient client = container.Resolve<IRestClient>(new ParameterOverride("baseUrl", wallServiceBaseUri));
                
                CommandList.BackCommand = container.Resolve<BackCommand>();
                CommandList.ExitCommand = container.Resolve<ExitCommand>();
                CommandList.SelectCardCommand = container.Resolve<SelectCardCommand>();
                CommandList.SelectWallCommand = container.Resolve<SelectWallCommand>();


                INavigationService navigationService = container.Resolve<INavigationService>();
                navigationService.Initialise();

                MainWindow mainWindow = container.Resolve<MainWindow>();
                mainWindow.Show();
            };

        }
    }
}
