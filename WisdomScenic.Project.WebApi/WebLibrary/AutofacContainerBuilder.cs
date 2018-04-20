using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using Autofac;
using WisdomScenic.Project.Infrastructure;

namespace WisdomScenic.Project.WebApi.WebLibrary
{
    public class AutofacContainerBuilder
    {
        public static void BuildContainer()
        {
            var builder = new ContainerBuilder();
            #region DAL程序集注册

            var dalAssembly = Assembly.Load("WisdomScenic.Project.DAL");
            builder.RegisterAssemblyTypes(dalAssembly).AsImplementedInterfaces();
            #endregion

            #region BLL程序集注册
            var bllAssembly = Assembly.Load("WisdomScenic.Project.BLL");
            builder.RegisterAssemblyTypes(bllAssembly).AsImplementedInterfaces();
            #endregion

            var container = builder.Build();
            DIContainer.RegisterContainer(container);
        }
    }
}