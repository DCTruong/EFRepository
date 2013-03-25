using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Infrastructure.EF;
using Microsoft.Practices.Unity;
using Infrastructure.EF.Repository;
using Web.Controllers;
using Unity.Mvc3;
using Service;
using Domain.Entities;
using Infrastructure.EF.Infrastructure;
using WebMatrix.Data;
using System.Data.Entity;

namespace Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();


            var context = new Context();
            context.Database.Initialize(true);

            //System.Data.Entity.Database.SetInitializer(new SchoolContextInitializer());

            IUnityContainer container = GetUnityContainer();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private IUnityContainer GetUnityContainer()
        {
            IUnityContainer container = new UnityContainer()
            .RegisterType<IStudentRespository, StudentRepository>()
            .RegisterType<IController, StudentController>()
            .RegisterType<IStudentService, StudentService>()
            .RegisterType<IDatabaseFactory, DatabaseFactory>()
            .RegisterType(typeof(IRepository<>), typeof(Repository<>));
            return container;
        }
    }
}