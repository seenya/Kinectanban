using Kinectanban.WebAPI.Services;
using Microsoft.Practices.Unity;
using RestSharp;
using System.Web.Http;
using Unity.WebApi;

namespace Kinectanban.WebAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers

            container.RegisterTypes(
               AllClasses.FromAssembliesInBasePath(),
               WithMappings.FromMatchingInterface,
               WithName.Default,
               WithLifetime.ContainerControlled);

            container.RegisterType<IEnvironmentVariableService, EnvironmentVariableService>();
            container.RegisterType<IConfigurationService, ConfigurationService>();
            container.RegisterType<IRestClient, RestClient>(new InjectionConstructor(""));
            container.RegisterType<ITrelloRepositoryService, TrelloRepositoryService>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}