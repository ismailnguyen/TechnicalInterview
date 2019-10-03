using System.Web.Mvc;
using Microsoft.Practices.Unity;
using TechnicalInterview.Exercice3.DataLayer;
using TechnicalInterview.Exercice3.Services;
using Unity.Mvc3;

namespace TechnicalInterview.Exercice3
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();          

            container.RegisterType<IProductService, ProductService>();
            container.RegisterType<IProductRepository, ProductRepository>();

            return container;
        }
    }
}