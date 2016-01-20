using System;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Mvc;

namespace NM.Web.WebApplication.Timesheets.Infrastructure
{
    public class IocBootstrapper
    {
        public static IUnityContainer Initializer()
        {
            var container = BuildUnityContainer();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            return container;
        }
         
        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();
            //register all components
            container.RegisterType<United.Abstract.IRepository, United.Concrete.Repository>(new ContainerControlledLifetimeManager());

            RegisterTypes(container);
            return container;
        }

        private static void RegisterTypes(UnityContainer container)
        {
            
        }
    }
}