using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using Microsoft.AspNet.Identity;

namespace DoE.Auth.Identity
{

    using Models;
    using Auth.Api;
    using Controllers;
    using Lsm.Logger;
    using Lsm.Data.Repositories;
    using Microsoft.AspNet.Identity.EntityFramework;

    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            container.RegisterType<ILogger, BaseLogger>();
            container.RegisterType<IRepositoryStoreManager, RepositoryStoreManager>();
            container.RegisterType<BaseController>();
            container.RegisterType<HomeController>();
            container.RegisterType<IUserStore<ApplicationUser>,  UserStore<ApplicationUser>>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}